using System.Collections;
using UnityEngine;

public class ConfuseTurret : MonoBehaviour
{
    public GameObject ConfuseAOE;

    public AudioSource ConfusedAudio;

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
