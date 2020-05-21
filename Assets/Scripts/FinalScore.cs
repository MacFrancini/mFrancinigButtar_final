using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text myText;

    public void UpdateScore()
    {
      GetComponent<Text>().text = "FINAL SCORE: " + myText;
    }
}
