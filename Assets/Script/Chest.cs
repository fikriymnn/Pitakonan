using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour, Interacable
{
    [SerializeField] private string _prompt;
    public GameObject panelQuiz;
    float x, y, z;
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

    public void OnDestroy()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        x += Time.deltaTime * 20;
        y += Time.deltaTime * 20;
        z += Time.deltaTime * 20;

        transform.rotation = Quaternion.Euler(x,y,z);
    }
}
