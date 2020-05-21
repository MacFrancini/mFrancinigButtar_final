using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockManager : MonoBehaviour
{

    private float timer;
    private float maxTimer;
    public GameObject rock;

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
      StartCoroutine("SpawnRockTimer");
    }

    IEnumerator SpawnRockTimer()
    {
        while (true)
        {
            if (timer >= maxTimer)
            {
                // Spawn an enemy
                SpawnRock();
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

    void SpawnRock()
    {
      Vector3 spawnPoint = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 0.249f, 0));
      spawnPoint.z = 0;
      GameObject.Instantiate(rock, spawnPoint, new Quaternion(0, 0, 0, 0));

      //Adjusr x axis position
      float dist = (this.transform.position = Camera.main.transform.position).z;
      float topBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, dist)).y;
      float bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;
      Vector3 rockSize = rock.GetComponent<Renderer>().bounds.size;
      spawnPoint.x = Mathf.Clamp(spawnPoint.x, topBorder + rockSize.x / 2, bottomBorder - rockSize.x / 2);


    }


}
