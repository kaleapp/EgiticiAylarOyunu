using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public AudioSource backSound;
    public static bool soundPrefer = true;
    public GameObject soundOffButton, soundOnButton;
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
    }
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quiz()
    {
        SceneManager.LoadScene("Quiz");
    }
    public void Help()
    {
        SceneManager.LoadScene("Help");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Learning()
    {
        SceneManager.LoadScene("Learning");
    }
    public void SoundControl()
    {
        if(soundPrefer)
        {
            soundPrefer = false;
            backSound.Stop();
            soundOnButton.SetActive(false);
            soundOffButton.SetActive(true);
        }
        else
        {
            soundPrefer = true;
            backSound.Play();
            soundOnButton.SetActive(true);
            soundOffButton.SetActive(false);
        }
    }

}
