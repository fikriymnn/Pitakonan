using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MatchLogic : MonoBehaviour
{
    static MatchLogic Instance;

    public int maxPoints = 3;
    public TextMeshProUGUI pointsText;
    public GameObject levelCompleteUI;
    public GameObject currentLevelUI;
    public GameObject nextPanelUI;
    private int points = 0;
    public GameObject btnNext;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    void UpdatePointsText()
    {
        pointsText.text = points + "/" + maxPoints;
        if (points == maxPoints)
        {
            levelCompleteUI.SetActive(true);
            currentLevelUI.SetActive(false);
            btnNext.SetActive(true);
        }
    }

    public void NextButton()
    {
        currentLevelUI.SetActive(false);
        nextPanelUI.SetActive(true);
    }

    public static void AddPoint()
    {
        AddPoints(1);
    }

    public static void AddPoints(int points)
    {
        Instance.points += points;
        Instance.UpdatePointsText();
    }

    public void Close()
    {
        currentLevelUI.SetActive(false);
    }
}
