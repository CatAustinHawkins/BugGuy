using System.Collections;
using UnityEngine;

public class Wave3Spawn : MonoBehaviour
{
    public GameObject Wave4Spawning;
    public int NormalEnemyCount;
    public GameObject[] Enemies;
    public AudioSource WaveAudio;

    public int RandomCount;
    public GameObject WaveUI;
    public GameObject PreviousWaveUI;
    private void Start()
    {
        StartCoroutine(NormalEnemySpawn());
        WaveUI.SetActive(true);
        WaveAudio.Play();
        PreviousWaveUI.SetActive(false);
        StartCoroutine(UIDelay());
    }

    void NormalEnemySpawning()
    {
        if (NormalEnemyCount < 15)
        {
            RandomCount = Random.Range(0, 3);
            Instantiate(Enemies[RandomCount], transform.position, transform.rotation);
            NormalEnemyCount++;

            StartCoroutine(NormalEnemySpawn());
        }

        if (NormalEnemyCount >= 15)
        {
            StartCoroutine(WaveEndPause());
        }
    }

    IEnumerator WaveEndPause()
    {
        yield return new WaitForSecondsRealtime(3f);
        Wave4Spawning.SetActive(true);
        Destroy(gameObject);
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