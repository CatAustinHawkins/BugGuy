using System.Collections;
using UnityEngine;

public class Wave9Spawn : MonoBehaviour
{
    public GameObject Wave10Spawning;
    public int HeavyEnemyCount;
    public int NormalEnemyCount;
    public int FlyingEnemyCount;
    public int LightEnemyCount;
    public AudioSource WaveAudio;

    public GameObject[] LightEnemies;
    public GameObject[] HeavyEnemy;
    public GameObject[] NormalEnemies;
    public GameObject FlyingEnemy;

    public GameObject WaveUI;
    public GameObject PreviousWaveUI;

    public int RandomCount;
    public int RandomCount2;
    public int RandomCount3;

    private void Start()
    {
        StartCoroutine(HeavyEnemySpawn());
        StartCoroutine(NormalEnemySpawn());
        StartCoroutine(FlyingEnemySpawn());
        StartCoroutine(LightEnemySpawn());
        StartCoroutine(UIDelay());
        WaveUI.SetActive(true);
        WaveAudio.Play();
        PreviousWaveUI.SetActive(false);
    }

    void HeavyEnemySpawning()
    {
        if (HeavyEnemyCount < 5)
        {
            RandomCount3 = Random.Range(0, 2);
            Instantiate(HeavyEnemy[RandomCount3], transform.position, transform.rotation);
            HeavyEnemyCount++;

            StartCoroutine(HeavyEnemySpawn());
        }

        if (HeavyEnemyCount >= 5 && NormalEnemyCount >= 10 && FlyingEnemyCount >= 5 && LightEnemyCount >= 5)
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

        if (HeavyEnemyCount >= 5 && NormalEnemyCount >= 10 && FlyingEnemyCount >= 5 && LightEnemyCount >= 5)
        {
            StartCoroutine(WaveEndPause());
        }
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

        if (HeavyEnemyCount >= 5 && NormalEnemyCount >= 10 && FlyingEnemyCount >= 5 && LightEnemyCount >= 5)
        {
            StartCoroutine(WaveEndPause());
        }
    }

    void FlyingEnemySpawning()
    {
        if (FlyingEnemyCount < 5)
        {
            Instantiate(FlyingEnemy, transform.position, transform.rotation);
            FlyingEnemyCount++;

            StartCoroutine(FlyingEnemySpawn());
        }

        if (HeavyEnemyCount >= 5 && NormalEnemyCount >= 10 && FlyingEnemyCount >= 5 && LightEnemyCount >= 5)
        {
            StartCoroutine(WaveEndPause());
        }
    }

    IEnumerator WaveEndPause()
    {
        yield return new WaitForSecondsRealtime(3f);
        Wave10Spawning.SetActive(true);
        Destroy(gameObject);
    }

    IEnumerator HeavyEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        HeavyEnemySpawning();
    }

    IEnumerator NormalEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(2.5f);
        NormalEnemySpawning();
    }

    IEnumerator FlyingEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(2.5f);
        FlyingEnemySpawning();
    }

    IEnumerator LightEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(2.5f);
        LightEnemySpawning();
    }

    IEnumerator UIDelay()
    {
        yield return new WaitForSecondsRealtime(7f);
        WaveUI.SetActive(false);
    }
}