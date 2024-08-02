using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoPanelMatch : MonoBehaviour
{
    public GameObject goPanel;
    public GameObject nextLevel;

    public void goToLvl2()
    {
        goPanel.SetActive(false);
        nextLevel.SetActive(true);
    }
}
