using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTwo : MonoBehaviour
{
    [SerializeField] private string _prompt;
    public GameObject panelQuiz;
    //public GameObject hideGoPanel;
    //public QuizPG quizManager;

    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Collect Item!");
        //quizManager.generateQuestion();
        panelQuiz.SetActive(true);
        //hideGoPanel.SetActive(false);
        return true;
    }
}
