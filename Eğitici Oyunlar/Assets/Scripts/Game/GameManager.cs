using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text numberText, answerText1, answerText2, answerText3;
    public static int number, correctAnswer;
    string[] aylar = { "ocak", "þubat", "mart", "nisan", "mayýs", "haziran", "temmuz", "aðustos", "eylül", "ekim", "kasým", "aralýk" };

    private void Start()
    {
        number = Random.Range(1, 13);
        numberText.text = number.ToString() + ". Ay Hangisidir?";
        correctAnswer = Random.Range(1, 4);
        switch (correctAnswer)
        {
            case 1:
                answerText1.text= aylar[number-1];
                int a;
                int b;
                do
                {
                    a = Random.Range(1, 13);
                } while (a == number);
                answerText2.text= aylar[a-1];
                do
                {
                    b = Random.Range(1, 13);
                } while (a == number);
                answerText3.text = aylar[b - 1];
                break;
            case 2:
                answerText2.text = aylar[number - 1];
                do
                {
                    a = Random.Range(1, 13);
                } while (a == number);
                answerText1.text = aylar[a - 1];
                do
                {
                    b = Random.Range(1, 13);
                } while (a == number);
                answerText3.text = aylar[b - 1];
                break;
            case 3:
                answerText3.text = aylar[number - 1];
                do
                {
                    a = Random.Range(1, 13);
                } while (a == number);
                answerText2.text = aylar[a - 1];
                do
                {
                    b = Random.Range(1, 13);
                } while (a == number);
                answerText1.text = aylar[b - 1];
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


}
