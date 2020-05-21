using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DifficultyMenu : MonoBehaviour
{

    public void PlayEasy()
    {
        SceneManager.LoadScene("Easy");
    }

    public void PlayNormal()
    {
        SceneManager.LoadScene("Normal");
    }

    public void PlayHard()
    {
        SceneManager.LoadScene("Hard");
    }

}
