using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Question
{
    public string question;
    public string correctAnswer;
    public Question(string q, string c)
    {
        question = q;
        correctAnswer = c;
    }
}
public class FlashCardFlip : MonoBehaviour
{
    public RectTransform r;
    public TextMeshProUGUI cardText;
    public GameObject chest;
    public GameObject panel;
    public TextMeshProUGUI btnText;

    public bool isCompletedFlashCard = false;

    public TMP_FontAsset FontAssetA;
    public TMP_FontAsset FontAssetB;

    public Question[] ques = new Question[25];

    private float flipTime = 0.5f;
    private int faceSide = 0; //0=front, 1=back
    private int isShrinking = -1; //-1 = get smaller, 1 = get bigger
    private bool isFlipping = false;
    private int cardNum = 0;
    private float distancePerTime;
    private float timeCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        ques[0] = new Question("Ka", "k");
        ques[1] = new Question("Qa", "q");
        ques[2] = new Question("Xa", "X");
        ques[3] = new Question("Ga", "g");
        ques[4] = new Question("Nga", "N");
        ques[5] = new Question("Ca", "c");
        ques[6] = new Question("Ja", "j");
        ques[7] = new Question("Za", "z");
        ques[8] = new Question("Nya", "Y");
        ques[9] = new Question("Ta", "t");
        ques[10] = new Question("Da", "d");
        ques[11] = new Question("Na", "n");
        ques[12] = new Question("Pa", "p");
        ques[13] = new Question("Fa", "f");
        ques[14] = new Question("Va", "v");
        ques[15] = new Question("Ba", "b");
        ques[16] = new Question("Ma", "m");
        ques[17] = new Question("Ya", "y");
        ques[18] = new Question("Ra", "r");
        ques[19] = new Question("La", "l");
        ques[20] = new Question("Wa", "w");
        ques[21] = new Question("Sa", "s");
        ques[22] = new Question("Ha", "h");
        ques[23] = new Question("Kha", "K");
        ques[24] = new Question("Sya", "S");

        distancePerTime = r.localScale.x / flipTime;
        cardNum = 0;
        cardText.font = FontAssetA;
        cardText.text = ques[cardNum].question;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFlipping)
        {
            Vector3 v = r.localScale;
            v.x += isShrinking * distancePerTime * Time.deltaTime;
            r.localScale = v;

            timeCount += Time.deltaTime;
            if((timeCount >= flipTime) && (isShrinking < 0))
            {
                isShrinking = 1;
                timeCount = 0;
                if (faceSide == 0)
                {
                    faceSide = 1;
                    cardText.text = ques[cardNum].correctAnswer;
                    cardText.font = FontAssetB;
                    cardText.fontSize = 230;
                }
                else
                {
                    faceSide = 0;
                    cardText.text = ques[cardNum].question;
                    cardText.font = FontAssetA;
                    cardText.fontSize = 125;
                }
            }
            else if ((timeCount >= flipTime) && isShrinking == 1)
            {
                isFlipping = false;
            }
        }
    }

    public void  NextCard()
    {
        faceSide = 0;
        cardText.font = FontAssetA;
        cardText.fontSize = 125;
        cardNum++;
        if (cardNum >= ques.Length)
        {       
            cardNum = 0;
            Destroy(chest);
            panel.SetActive(false);
            isCompletedFlashCard = true;
        }
        if (cardNum == 24)
        {
            btnText.text = "Finish";
        }
        cardText.text = ques[cardNum].question;
        
    }

    public void FlipCard()
    {
        timeCount = 0;
        isFlipping = true;
        isShrinking = -1;
    }

    public void close()
    {
        panel.SetActive(false);
    }
}
