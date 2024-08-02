using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MatchLogicTwo : MonoBehaviour
{
    static MatchLogicTwo Instance;

    public int maxPoints = 14;
    public TextMeshProUGUI pointsText;
    public GameObject levelCompleteUI;
    public GameObject currentLevelUI;
    private int points = 0;

    public GameObject chest;

    public bool isCompletedMatchLogic = false;


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
            Destroy(chest);
            isCompletedMatchLogic = true;
        }
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

    public void hidePanelCompleted()
    {
        levelCompleteUI.SetActive(false);
    }

    public void Close()
    {
        currentLevelUI.SetActive(false);
    }
}
