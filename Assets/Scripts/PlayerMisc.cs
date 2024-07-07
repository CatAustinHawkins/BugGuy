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

    public AudioSource LilypadAudio;
    public AudioSource LilypadAudio2;

    public GameObject Wave1;

    public GameObject PlayerArm;

    public int RandomInt;
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
            PlayerArm.SetActive(false);
        }

        if(other.tag == "Lilypad")
        {
            RandomInt = Random.Range(0, 3);

            if (RandomInt == 1)
            {
                LilypadAudio.Play();

            }
            else
            {
                LilypadAudio2.Play();

            }
        }


        if (other.tag == "WaveStart")
        {
            Wave1.SetActive(true);

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
        PlayerArm.SetActive(true);

    }
}
