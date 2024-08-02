using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectChar : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;


    public GameObject SelectCanvas;
    public GameObject Controller;

    public bool isJawa = true;
    public bool isBali = false;
    public bool isPadang = false;

    public GameObject JIndicate;
    public GameObject BIndicate;

    public GameObject JawaChar;
    public GameObject BaliChar;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "CharJawa")
                {
                    
                }
                if (hit.collider.gameObject.name == "CharBali")
                {
                   
                }
            }
        }
    } 

    public void JawaSelect()
    {
        isJawa = true;
        isBali = false;
        isPadang = false;

        Debug.Log("Jawa Selected");

        JIndicate.SetActive(true);
        BIndicate.SetActive(false);

        JawaChar.SetActive(true);
        BaliChar.SetActive(false);

    }
    public void BaliSelect()
    {
        isJawa = false;
        isBali = true;
        isPadang = false;

        Debug.Log("Bali Selected");

        BIndicate.SetActive(true);
        JIndicate.SetActive(false);

        BaliChar.SetActive(true);
        JawaChar.SetActive(false);
    }
    public void playNow()
    {
        
        SelectCanvas.SetActive(false);
        Controller.SetActive(true);


    }

}
