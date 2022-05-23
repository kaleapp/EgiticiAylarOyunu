using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    List<List<string>> questions = new List<List<string>>();
    public Text questionText, aText, bText, cText, trueText, falseText;
    string correctOption;
    int count=0;
    int control = 8;
    public Image winImage, loseImage;
    public GameObject finishPanel, gamePanel;
    int trueCount, falseCount;
    public Button aButton, bButton, cButton;
    public AudioSource correctSound, wrongSound;
    private void Awake()
    {
        questions.Add(new List<string>());
        questions[0].Add("Hangisi yaz mevsimine ait bir aydýr?");
        questions[0].Add("A) Mart");
        questions[0].Add("B) Eylül");
        questions[0].Add("C) Haziran");
        questions[0].Add("c");

        questions.Add(new List<string>());
        questions[1].Add("Aþaðýdakilerden hangisi ilkbahar ayýdýr?");
        questions[1].Add("A) Mart");
        questions[1].Add("B) Eylül");
        questions[1].Add("C) Haziran");
        questions[1].Add("a");

        questions.Add(new List<string>());
        questions[2].Add("Aþaðýdakilerden hangisi  9. Aydýr?");
        questions[2].Add("A) Mart");
        questions[2].Add("B) Haziran");
        questions[2].Add("C) Eylül");
        questions[2].Add("c");

        questions.Add(new List<string>());
        questions[3].Add("“…… ayý soðuk ve yaðýþlýdýr.” Boþluklu yere uygun seçeneði seçiniz.");
        questions[3].Add("A) Mart");
        questions[3].Add("B) Aralýk");
        questions[3].Add("C) Haziran");
        questions[3].Add("b");

        questions.Add(new List<string>());
        questions[4].Add("“……... ayý temmuzdan sonra gelir.” Boþluklu yere uygun seçeneði seçiniz.");
        questions[4].Add("A) Nisan");
        questions[4].Add("B) Eylül");
        questions[4].Add("C) Aðustos");
        questions[4].Add("c");

        questions.Add(new List<string>());
        questions[5].Add("Aþaðýdaki aylarýn yazýmlarýndan hangisi doðrudur ?");
        questions[5].Add("A) Zort");
        questions[5].Add("B) Eylil");
        questions[5].Add("C) Haziran");
        questions[5].Add("c");

        questions.Add(new List<string>());
        questions[6].Add("Yýlýn ilk ayý hangi aydýr ?");
        questions[6].Add("A) Ocak");
        questions[6].Add("B) Eylül");
        questions[6].Add("C) Haziran");
        questions[6].Add("a");

        questions.Add(new List<string>());
        questions[7].Add("Yýlýn son ayý hangi aydýr ?");
        questions[7].Add("A) Ekim");
        questions[7].Add("B) Eylül");
        questions[7].Add("C) Aralýk");
        questions[7].Add("c");

        questions.Add(new List<string>());
        questions[8].Add("Hangi ay sonbahar mevsimine aittir ?");
        questions[8].Add("A) Ocak");
        questions[8].Add("B) Kasým");
        questions[8].Add("C) Aralýk");
        questions[8].Add("b");
    }
    private void Start()
    {
        
        questionText.text = questions[count][0];
        aText.text = questions[count][1];
        bText.text = questions[count][2];
        cText.text = questions[count][3];
        correctOption = questions[count][4];
            
    }
    public void ButtonA()
    {
        if(correctOption == "a")
        {
            correctSound.Play();
            winImage.gameObject.SetActive(true);
            ++trueCount;
            ButtonShow(false);
        }
        else
        {
            wrongSound.Play();
            loseImage.gameObject.SetActive(true);
            ++falseCount;
            ButtonShow(false);
        }
    }
    public void ButtonB()
    {
        if (correctOption == "b")
        {
            correctSound.Play();
            winImage.gameObject.SetActive(true);
            ++trueCount;
            ButtonShow(false);
        }
        else
        {
            wrongSound.Play();
            loseImage.gameObject.SetActive(true);
            ++falseCount;
            ButtonShow(false);
        }
    }
    public void ButtonC()
    {
        if (correctOption == "c")
        {
            correctSound.Play();
            winImage.gameObject.SetActive(true);
            ++trueCount;
            ButtonShow(false);
        }
        else
        {
            wrongSound.Play();
            loseImage.gameObject.SetActive(true);
            ++falseCount;
            ButtonShow(false);
        }
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Next()
    {
        if(count < control)
        {
            ++count;
            ButtonShow(true);
            questionText.text = questions[count][0];
            aText.text = questions[count][1];
            bText.text = questions[count][2];
            cText.text = questions[count][3];
            correctOption = questions[count][4];
            winImage.gameObject.SetActive(false);
            loseImage.gameObject.SetActive(false);
        }
        else
        {
            gamePanel.SetActive(false);
            finishPanel.SetActive(true);
            trueText.text = trueCount.ToString();
            falseText.text = falseCount.ToString();

        }     
    }
    void ButtonShow(bool x)
    {
        aButton.interactable = x;
        bButton.interactable = x;
        cButton.interactable = x;
    }
    
}

