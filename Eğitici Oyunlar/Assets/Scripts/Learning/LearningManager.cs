using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LearningManager : MonoBehaviour
   
{
    public GameObject ocakPanel, subatPanel, martPanel, nisanPanel, mayisPanel, haziranPanel, temmuzPanel, agustosPanel, eylülPanel, ekimPanel, kasimPanel, aralikPanel, mainPanel, soundOnButton, soundOffButton;
    public GameObject currentPanel;
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
    }
    public void Ocak()
    {
        currentPanel = ocakPanel;
        ocakPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Subat()
    {
        currentPanel = subatPanel;
        subatPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Mart()
    {
        currentPanel = martPanel;
        martPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Nisan()
    {
        currentPanel = nisanPanel;
        nisanPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Mayis()
    {
        currentPanel = mayisPanel;
        mayisPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Haziran()
    {
        currentPanel = haziranPanel;
        haziranPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Temmuz()
    {
        currentPanel = temmuzPanel;
        temmuzPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Agustos()
    {
        currentPanel = agustosPanel;
        agustosPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Eylül()
    {
        currentPanel = eylülPanel;
        eylülPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Ekim()
    {
        currentPanel = ekimPanel;
        ekimPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Kasim()
    {
        currentPanel = kasimPanel;
        kasimPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Aralik()
    {
        currentPanel = aralikPanel;
        aralikPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void Back()
    {
        currentPanel.SetActive(false);
        mainPanel.SetActive(true);
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
