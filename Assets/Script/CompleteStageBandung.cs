using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteStageBandung : MonoBehaviour
{
    public MatchLogicTwo mLogic;
    public FlashCardFlip fCard;
    public QuizManager wordGame;

    public GameObject panelGameCompleted;

    void Update()
    {
        if ((mLogic.isCompletedMatchLogic == true) && (fCard.isCompletedFlashCard == true) && (wordGame.isCompletedWordLogic == true))
        {
            panelGameCompleted.SetActive(true);
        }
        else if ((mLogic.isCompletedMatchLogic == false) && (fCard.isCompletedFlashCard == false) && (wordGame.isCompletedWordLogic == false))
        {
            panelGameCompleted.SetActive(false);
        }
    }

    public void EndGame()
    {
        mLogic.isCompletedMatchLogic = false;
        fCard.isCompletedFlashCard = false;
        wordGame.isCompletedWordLogic = false;
        panelGameCompleted.SetActive(false);
    }

    public void map()
    {
        SceneManager.LoadScene("IntoductionScene");
    }
}
