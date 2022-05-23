using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text numberText, answerText1, answerText2, answerText3, skorText;
    public static int number, correctAnswer;
    string[] months = { "Ocak", "Þubat", "Mart", "Nisan", "Mayýs", "Haziran", "Temmuz", "Aðustos", "Eylül", "Ekim", "Kasým", "Aralýk" };
    public static int skor;
    public GameObject soundOnButton, soundOffButton;
    public AudioSource backSound;

    private void Start()
    {
        if (MenuManager.soundPrefer)
        {
            backSound.Play();
            soundOnButton.SetActive(true);
            soundOffButton.SetActive(false);
        }
        else
        {
            backSound.Stop();
            soundOnButton.SetActive(false);
            soundOffButton.SetActive(true);
            
        }
        skor = PlayerPrefs.GetInt("skor");
        skorText.text = skor.ToString();
        number = Random.Range(1, 13);
        numberText.text = number.ToString() + ". Ay Hangisidir?";
        correctAnswer = Random.Range(1, 4);
        switch (correctAnswer)
        {
            case 1:
                answerText1.text = months[number - 1];
                int a;
                int b;
                do
                {
                    a = Random.Range(1, 13);
                } while (a == number);
                answerText2.text = months[a - 1];
                do
                {
                    b = Random.Range(1, 13);
                } while (b == number || b == a);
                answerText3.text = months[b - 1];
                break;
            case 2:
                answerText2.text = months[number - 1];
                do
                {
                    a = Random.Range(1, 13);
                } while (a == number);
                answerText1.text = months[a - 1];
                do
                {
                    b = Random.Range(1, 13);
                } while (b == number || b == a);
                answerText3.text = months[b - 1];
                break;
            case 3:
                answerText3.text = months[number - 1];
                do
                {
                    a = Random.Range(1, 13);
                } while (a == number);
                answerText2.text = months[a - 1];
                do
                {
                    b = Random.Range(1, 13);
                } while (b == number || b == a);
                answerText1.text = months[b - 1];
                break;

        }

    }
    public void Tekrar()
    {
        SceneManager.LoadScene("Game");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void SoundControl()
    {
        if (MenuManager.soundPrefer)
        {
            MenuManager.soundPrefer = false;
            backSound.Stop();
            soundOnButton.SetActive(false);
            soundOffButton.SetActive(true);
        }
        else
        {
            MenuManager.soundPrefer = true;
            backSound.Play();
            soundOnButton.SetActive(true);
            soundOffButton.SetActive(false);
        }
    }

}
