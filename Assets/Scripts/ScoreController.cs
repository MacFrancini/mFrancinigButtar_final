using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;

    public void UpdateScore()
    {
      GetComponent<Text>().text = "SCORE: " + score;
    }
}
