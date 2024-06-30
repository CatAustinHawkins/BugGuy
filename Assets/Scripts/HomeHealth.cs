using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeHealth : MonoBehaviour
{
    public Slider HealthBar;

    public float slidervalue = 1;

    private void Update()
    {
        if(slidervalue == 0)
        {

        }

        if(slidervalue < 0)
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            slidervalue = slidervalue - 0.1f;
            HealthBar.value = slidervalue;
        }
    }
}
