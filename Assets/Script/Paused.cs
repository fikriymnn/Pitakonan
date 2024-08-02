using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused : MonoBehaviour
{
    public GameObject controller;
    public GameObject panelPause;

    public void paused()
    {
        panelPause.SetActive(true);
        controller.SetActive(false);
    }

    public void resume()
    {
        panelPause.SetActive(false);
        controller.SetActive(true);
    }

    public void backMap()
    {
        SceneManager.LoadScene("IntoductionScene");
    }

    public void QuitApps()
    {
        Application.Quit();
    }
}
