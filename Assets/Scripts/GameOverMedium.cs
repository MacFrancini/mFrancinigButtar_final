using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverMedium : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("Normal");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
