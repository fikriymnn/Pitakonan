using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private bool isBandung = false;

    public GameObject BandungPanel;
    public GameObject panelConfirmQuit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void JabarButton()
    {
        if (!isBandung)
        {
            isBandung = true;
            BandungPanel.SetActive(true);
        }else
        {
            isBandung=false;
            BandungPanel.SetActive(false);
        }
    }
    public void BandungScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void confirmQuitPanel()
    {
        panelConfirmQuit.SetActive(true);
    }

    public void hidePanelConfirmQuit()
    {
        panelConfirmQuit.SetActive(false);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
