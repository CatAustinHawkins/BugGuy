using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfuseTurret : MonoBehaviour
{

    public GameObject ConfuseAOE;

    public AudioSource ConfusedAudio;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ConfuseDelay());

    }

    IEnumerator ConfuseDelay()
    {
        ConfuseAOE.SetActive(true);
        ConfusedAudio.Play();
        yield return new WaitForSecondsRealtime(6f);
        ConfuseAOE.SetActive(false);
        StartCoroutine(Delay());
    }


    IEnumerator Delay()
    {
        yield return new WaitForSecondsRealtime(12f);
        StartCoroutine(ConfuseDelay());
    }
}
