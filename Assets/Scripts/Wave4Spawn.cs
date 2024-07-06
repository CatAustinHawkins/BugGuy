using System.Collections;
using UnityEngine;

public class Wave4Spawn : MonoBehaviour
{
    public GameObject Wave5Spawning;
    public int LightEnemyCount;
    public GameObject[] Enemies;
    public AudioSource WaveAudio;

    public int RandomCount;
    public GameObject WaveUI;
    public GameObject PreviousWaveUI;
    private void Start()
    {
        StartCoroutine(LightEnemySpawn());
        WaveUI.SetActive(true);
        WaveAudio.Play();
        StartCoroutine(UIDelay());
        PreviousWaveUI.SetActive(false);
    }

    void LightEnemySpawning()
    {
        if (LightEnemyCount < 10)
        {
            RandomCount = Random.Range(0, 2);
            Instantiate(Enemies[RandomCount], transform.position, transform.rotation);
            LightEnemyCount++;

            StartCoroutine(LightEnemySpawn());
        }

        if (LightEnemyCount >= 10)
        {
            StartCoroutine(WaveEndPause());
        }
    }

    IEnumerator WaveEndPause()
    {
        yield return new WaitForSecondsRealtime(3f);
        Wave5Spawning.SetActive(true);
        Destroy(gameObject);
    }

    IEnumerator LightEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        LightEnemySpawning();
    }

    IEnumerator UIDelay()
    {
        yield return new WaitForSecondsRealtime(7f);
        WaveUI.SetActive(false);
    }
}