using System.Collections;
using UnityEngine;

public class Wave7Spawn : MonoBehaviour
{
    public GameObject Wave8Spawning;
    public int HeavyEnemyCount;
    public int FlyingEnemyCount;
    public GameObject[] HeavyEnemy;
    public GameObject FlyingEnemy;
    public AudioSource WaveAudio;

    public int RandomCount;
    public int RandomCount2;
    public GameObject WaveUI;
    public GameObject PreviousWaveUI;
    private void Start()
    {
        StartCoroutine(HeavyEnemySpawn());
        StartCoroutine(FlyingEnemySpawn());
        StartCoroutine(UIDelay());
        WaveAudio.Play();
        WaveUI.SetActive(true);
        PreviousWaveUI.SetActive(false);
    }

    void HeavyEnemySpawning()
    {
        if (HeavyEnemyCount < 5)
        {
            RandomCount = Random.Range(0, 2);
            Instantiate(HeavyEnemy[RandomCount], transform.position, transform.rotation);
            HeavyEnemyCount++;

            StartCoroutine(HeavyEnemySpawn());
        }

        if (HeavyEnemyCount >= 5 && FlyingEnemyCount >= 5)
        {
            StartCoroutine(WaveEndPause());
        }
    }

    void FlyingEnemySpawning()
    {
        if (FlyingEnemyCount < 10)
        {
            RandomCount2 = Random.Range(0, 3);
            Instantiate(FlyingEnemy, transform.position, transform.rotation);
            FlyingEnemyCount++;

            StartCoroutine(FlyingEnemySpawn());
        }

        if (HeavyEnemyCount >= 5 && FlyingEnemyCount >= 5)
        {
            StartCoroutine(WaveEndPause());
        }
    }

    IEnumerator WaveEndPause()
    {
        yield return new WaitForSecondsRealtime(3f);
        Wave8Spawning.SetActive(true);
        Destroy(gameObject);
    }

    IEnumerator HeavyEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        HeavyEnemySpawning();
    }

    IEnumerator FlyingEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(2.5f);
        FlyingEnemySpawning();
    }

    IEnumerator UIDelay()
    {
        yield return new WaitForSecondsRealtime(7f);
        WaveUI.SetActive(false);
    }
}

