using System.Collections;
using UnityEngine;

public class Wave10Spawn : MonoBehaviour
{
    public int HeavyEnemyCount;
    public int NormalEnemyCount;
    public int FlyingEnemyCount;

    public GameObject[] HeavyEnemy;
    public GameObject[] NormalEnemies;
    public GameObject FlyingEnemy;
    public GameObject BossEnemy;

    public GameObject WaveUI;
    public GameObject PreviousWaveUI;
    public AudioSource WaveAudio;

    public int RandomCount;
    public int RandomCount2;
    public int RandomCount3;

    private void Start()
    {
        StartCoroutine(HeavyEnemySpawn());
        StartCoroutine(NormalEnemySpawn());
        StartCoroutine(FlyingEnemySpawn());
        StartCoroutine(UIDelay());
        WaveUI.SetActive(true);
        PreviousWaveUI.SetActive(false);
        WaveAudio.Play();
    }

    void HeavyEnemySpawning()
    {
        if (HeavyEnemyCount < 10)
        {
            RandomCount3 = Random.Range(0, 2);
            Instantiate(HeavyEnemy[RandomCount3], transform.position, transform.rotation);
            HeavyEnemyCount++;

            StartCoroutine(HeavyEnemySpawn());
        }

        if (HeavyEnemyCount >= 10 && NormalEnemyCount >= 10 && FlyingEnemyCount >= 10)
        {
            StartCoroutine(BossSpawn());
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

        if (HeavyEnemyCount >= 10 && NormalEnemyCount >= 10 && FlyingEnemyCount >= 10)
        {
            StartCoroutine(BossSpawn());
        }
    }

    void FlyingEnemySpawning()
    {
        if (FlyingEnemyCount < 10)
        {
            Instantiate(FlyingEnemy, transform.position, transform.rotation);
            FlyingEnemyCount++;

            StartCoroutine(FlyingEnemySpawn());
        }

        if (HeavyEnemyCount >= 10 && NormalEnemyCount >= 10 && FlyingEnemyCount >= 10)
        {
            StartCoroutine(BossSpawn());
        }
    }

    IEnumerator HeavyEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(3f);
        HeavyEnemySpawning();
    }

    IEnumerator NormalEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(2.50f);
        NormalEnemySpawning();
    }

    IEnumerator FlyingEnemySpawn()
    {
        yield return new WaitForSecondsRealtime(2f);
        FlyingEnemySpawning();
    }

    IEnumerator BossSpawn()
    {
        yield return new WaitForSecondsRealtime(7.5f);
        Instantiate(BossEnemy, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    IEnumerator UIDelay()
    {
        yield return new WaitForSecondsRealtime(7f);
        WaveUI.SetActive(false);
    }
}