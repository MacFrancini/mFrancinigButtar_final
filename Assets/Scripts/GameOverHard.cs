using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverHard : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("Hard");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
