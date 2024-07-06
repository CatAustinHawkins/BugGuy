using System.Collections;
using UnityEngine;

public class Wave2Spawn : MonoBehaviour
{
    public GameObject Wave3Spawning;
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
        StartCoroutine(UIDelay());
        WaveAudio.Play();
        PreviousWaveUI.SetActive(false);
    }

    void NormalEnemySpawning()
    {
        if (NormalEnemyCount < 10)
        {
            RandomCount = Random.Range(0, 3);
            Instantiate(Enemies[RandomCount], transform.position, transform.rotation);
            NormalEnemyCount++;

            StartCoroutine(NormalEnemySpawn());
        }

        if (NormalEnemyCount >= 10)
        {
            StartCoroutine(WaveEndPause());
        }
    }

    IEnumerator WaveEndPause()
    {
        yield return new WaitForSecondsRealtime(3f);
        Wave3Spawning.SetActive(true);
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
