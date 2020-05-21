using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverEasy : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("Easy");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
