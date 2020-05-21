using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatManager : MonoBehaviour
{

    private float timer;
    private float maxTimer;
    public GameObject bat;

    public float timerMin;
    public float timerMax;
    public float timerAddition;
    // Start is called before the first frame update
    void Start()
    {
      timer = 300;
      maxTimer = Random.Range(timerMin, timerMax);
    }

    // Update is called once per frame
    void Update()
    {
      StartCoroutine("SpawnBatTimer");
    }

    IEnumerator SpawnBatTimer()
    {
        while (true)
        {
            if (timer >= maxTimer)
            {
                // Spawn an enemy
                SpawnBat();
                timer = 300;
                maxTimer = Random.Range(timerMin, timerMax);
                if (timerMax > 1)
                {
                  timerMax -= timerAddition;
                }
            }

           timer += timerAddition;
            yield return new WaitForSeconds(timerAddition);
        }
    }

    void SpawnBat()
    {
      Vector3 spawnPoint = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 0.5f, 0));
      spawnPoint.z = 0;
      GameObject.Instantiate(bat, spawnPoint, new Quaternion(0, 0, 0, 0));

      //Adjusr x axis position
      float dist = (this.transform.position = Camera.main.transform.position).z;
      float topBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, dist)).y;
      float bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;
      Vector3 batSize = bat.GetComponent<Renderer>().bounds.size;
      spawnPoint.x = Mathf.Clamp(spawnPoint.x, topBorder + batSize.x / 2, bottomBorder - batSize.x / 2);


    }


}
