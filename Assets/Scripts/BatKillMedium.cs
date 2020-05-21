using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class BatKillMedium : MonoBehaviour
{

  public Text scoreText;
  public int finalScore;

  void Start() {
    scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      Destroy(this.gameObject);
      GameObject.Destroy(this.gameObject);
      GameObject.Destroy(collision.gameObject);
      finalScore = scoreText.GetComponent<ScoreController>().score;
      SceneManager.LoadSceneAsync("GameOverMedium", LoadSceneMode.Additive);
    }
  }

}
