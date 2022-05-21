using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Top : MonoBehaviour
{
    public Transform okTransform;
    public float guc;
    public Text sonucText;
    public Button firlatButton;

    public void Firlat()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(guc * okTransform.rotation.z, 20);
        firlatButton.gameObject.SetActive(false);
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        Invoke("TopuYokEt", 1.5f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == GameManager.correctAnswer.ToString())
        {
            Destroy(gameObject);
            sonucText.color = Color.green;
            sonucText.text = "Tebrikler Doðru Cevap";
        }
        else if (other.tag == "çevre")
        {
            Destroy(gameObject);
            sonucText.color = Color.red;
            sonucText.text = "Baþarýsýz Atýþ";
        }
        else
        {
            Destroy(gameObject);
            sonucText.color = Color.red;
            sonucText.text = "Yanlýþ Cevap";
        }
    }
    void TopuYokEt()
    {
        if(gameObject != null)
        {
            Destroy (gameObject);
            sonucText.color = Color.red;
            sonucText.text = "Baþarýsýz Atýþ";
        }
    }

}
