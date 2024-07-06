using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerMisc : MonoBehaviour
{
    public bool GunTwoPowerUp;
    public int Gold;
    public TextMeshProUGUI Goldtext;
    public GameObject SecondGun;

    public Animator GunAnim;
    public GameObject GunUI;
    public Image GunUI2;

    public AudioSource PowerUpCollect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Goldtext.text = Gold + "g";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GunTwoPowerUp")
        {
            GunTwoPowerUp = true;
            SecondGun.SetActive(true);
            GunUI.SetActive(true);
            PowerUpCollect.Play();
            StartCoroutine(PowerUpWait());
        }
    }

    IEnumerator PowerUpWait()
    {
        yield return new WaitForSecondsRealtime(10f);
        GunAnim.Play("New Animation");
        yield return new WaitForSecondsRealtime(5f);
        GunTwoPowerUp = false;
        GunAnim.StopPlayback();
        SecondGun.SetActive(false);
        GunUI2.color = Color.white;
        GunUI.SetActive(false);
    }
}
