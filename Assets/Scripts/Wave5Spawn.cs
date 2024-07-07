using System.Collections;
using UnityEngine;

public class Wave5Spawn : MonoBehaviour
{
    public GameObject Wave6Spawning;
    public int LightEnemyCount;
    public int NormalEnemyCount;
    public GameObject[] LightEnemies;
    public GameObject[] NormalEnemies;
    public AudioSource WaveAudio;

    public int RandomCount;
    public int RandomCount2;
    public GameObject WaveUI;
    public GameObject PreviousWaveUI;
    private void Start()
    {
        StartCoroutine(LightEnemySpawn());
        StartCoroutine(NormalEnemySpawn());
        StartCoroutine(UIDelay());
        WaveAudio.Play();
        WaveUI.SetActive(true);
        PreviousWaveUI.SetActive(false);
    }

    void LightEnemySpawning()
    {
        if (LightEnemyCount < 5)
        {
            RandomCount = Random.Range(0, 2);
            Instantiate(LightEnemies[RandomCount], transform.position, transform.rotation);
            LightEnemyCount++;

            StartCoroutine(LightEnemySpawn());
        }

        if (LightEnemyCount >= 5 && NormalEnemyCount >= 10)
        {
            StartCoroutine(WaveEndPause());
        }
    }

    void NormalEnemySpawning()
    {
        if (NormalEnemyCount < 10)
        {
            RandomCount2 = Random.Range(0, 3);
            Instantiate(NormalEnemies[RandomCount2], transform.position, transform.rotation);
            NormalEnemyCount++;

            StartCoroutine(NormalEnemySpawn());
        }

        if (LightEnemyCount >= 5 && NormalEnemyCount >= 10)
        {
            StartCoroutine(WaveEndPause());
        }
    }

    IEnumerator WaveEndPause()
    {
        yield return new WaitForSecondsRealtime(5f);
        Wave6Spawning.SetActive(true);
        Destroy(gameObject);
    }

    IEnumerator LightEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        LightEnemySpawning();
    }

    IEnumerator NormalEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(2.5f);
        NormalEnemySpawning();
    }

    IEnumerator UIDelay()
    {
        yield return new WaitForSecondsRealtime(7f);
        WaveUI.SetActive(false);
    }
}
