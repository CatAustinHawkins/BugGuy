using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeHealth : MonoBehaviour
{
    public Slider HealthBar;

    public float slidervalue = 1;

    public Image SliderImage;

    public Sprite HomeHealth75;
    public Sprite HomeHealth50;
    public Sprite HomeHealth25;

    public AudioSource HomeDamage1;
    public AudioSource HomeDamage2;

    public int RandomInt;
    private void Update()
    {
        if(slidervalue < 0.75)
        {
            SliderImage.sprite = HomeHealth75;
        }

        if (slidervalue < 0.50)
        {
            SliderImage.sprite = HomeHealth50;
        }

        if (slidervalue < 0.25)
        {
            SliderImage.sprite = HomeHealth25;

        }

        if (slidervalue < 0.05)
        {
            SceneManager.LoadScene("Lost");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            slidervalue = slidervalue - 0.05f;
            HealthBar.value = slidervalue;

            RandomInt = Random.Range(0, 3);

            if (RandomInt == 1)
            {
                HomeDamage1.Play();

            }
            else
            {
                HomeDamage2.Play();

            }
        }

        if (other.GetComponent<EnemyHealth>().Boss == true)
        {
            SceneManager.LoadScene("Lost");
        }

        if (other.tag == "Boss")
        {
            slidervalue =  0f;
            HealthBar.value = slidervalue;
        }
    }
}
