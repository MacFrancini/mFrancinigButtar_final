using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockController : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    private Rigidbody2D rb;
    public Text scoreText;
    void Start()
    {
      scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
      rb = GetComponent<Rigidbody2D>();
      rb.velocity = new Vector2((-speed), 0);
    }

    // Update is called once per frame
    void Update()
    {
      if (Camera.main.WorldToViewportPoint(transform.position).x < 0) {
        scoreText.GetComponent<ScoreController>().score += 5;
        scoreText.GetComponent<ScoreController>().UpdateScore();
        Destroy(this.gameObject);
      }
    }
}
