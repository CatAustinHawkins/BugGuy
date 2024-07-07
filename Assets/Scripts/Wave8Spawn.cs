using System.Collections;
using UnityEngine;

public class Wave8Spawn : MonoBehaviour
{
    public GameObject Wave9Spawning;
    public int HeavyEnemyCount;
    public int NormalEnemyCount;
    public int FlyingEnemyCount;
    public AudioSource WaveAudio;

    public GameObject[] HeavyEnemy;
    public GameObject[] NormalEnemies;
    public GameObject FlyingEnemy;

    public int RandomCount;
    public int RandomCount2;
    public int RandomCount3;
    public GameObject WaveUI;
    public GameObject PreviousWaveUI;
    private void Start()
    {
        StartCoroutine(HeavyEnemySpawn());
        StartCoroutine(NormalEnemySpawn());
        StartCoroutine(FlyingEnemySpawn());
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

        if (HeavyEnemyCount >= 5 && NormalEnemyCount >= 10 && FlyingEnemyCount >= 5)
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

        if (HeavyEnemyCount >= 5 && NormalEnemyCount >= 10 && FlyingEnemyCount >= 5)
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

        if (HeavyEnemyCount >= 5 && NormalEnemyCount >= 10 && FlyingEnemyCount >= 5)
        {
            StartCoroutine(WaveEndPause());
        }
    }

    IEnumerator WaveEndPause()
    {
        yield return new WaitForSecondsRealtime(5f);
        Wave9Spawning.SetActive(true);
        Destroy(gameObject);
    }

    IEnumerator HeavyEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(4f);
        HeavyEnemySpawning();
    }

    IEnumerator NormalEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(3f);
        NormalEnemySpawning();
    }

    IEnumerator FlyingEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(2f);
        FlyingEnemySpawning();
    }

    IEnumerator UIDelay()
    {
        yield return new WaitForSecondsRealtime(7f);
        WaveUI.SetActive(false);
    }
}