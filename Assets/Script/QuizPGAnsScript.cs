using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizPGAnsScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizPG quizManager;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();
        } else
        {
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }
}
