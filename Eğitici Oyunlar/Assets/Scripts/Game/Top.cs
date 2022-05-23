using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Top : MonoBehaviour
{
    public Transform okTransform;
    public float guc;
    public Text sonucText;
    public Button firlatButton, tekrarButton, menuButton;
    public AudioSource golSound, hitSound, wrongSound;

    public void Firlat()
    {
        hitSound.Play();
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(guc * okTransform.rotation.z, 20);
        firlatButton.gameObject.SetActive(false);
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        Invoke("TopuYokEt", 1.5f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        ShowButtons();
        if (other.tag == GameManager.correctAnswer.ToString())
        {
            golSound.Play();
            Destroy(gameObject);
            sonucText.color = Color.green;
            sonucText.text = "Tebrikler Doðru Cevap";
            GameManager.skor += 1;
            PlayerPrefs.SetInt("skor", GameManager.skor);
        }
        else if (other.tag == "çevre")
        {
            wrongSound.Play();
            Destroy(gameObject, 1f);
            sonucText.color = Color.red;
            sonucText.text = "Baþarýsýz Atýþ";
            GameManager.skor -= 1;
            PlayerPrefs.SetInt("skor", GameManager.skor);
        }
        else
        {
            wrongSound.Play();
            Destroy(gameObject);
            sonucText.color = Color.red;
            sonucText.text = "Yanlýþ Cevap";
            GameManager.skor -= 1;
            PlayerPrefs.SetInt("skor", GameManager.skor);
        }
    }
    void TopuYokEt()
    {
        if(gameObject != null)
        {
            wrongSound.Play();
            Destroy (gameObject);
            sonucText.color = Color.red;
            sonucText.text = "Baþarýsýz Atýþ";
            GameManager.skor -= 1;
            PlayerPrefs.SetInt("skor", GameManager.skor);
            ShowButtons();
        }
    }
    void ShowButtons()
    {
        tekrarButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
    }

}
