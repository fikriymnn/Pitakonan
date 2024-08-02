using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelQuiz : MonoBehaviour
{
    public GameObject hidePanel;
    

    public void hidePanelQuiz()
    {
        hidePanel.SetActive(false);
    }
}
