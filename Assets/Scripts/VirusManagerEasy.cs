using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class VirusManagerEasy : MonoBehaviour
{

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      Destroy(this.gameObject);
      GameObject.Destroy(this.gameObject);
      GameObject.Destroy(collision.gameObject);
      SceneManager.LoadSceneAsync("GameOverEasy", LoadSceneMode.Additive);
    }
  }

}
