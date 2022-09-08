using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nav : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}