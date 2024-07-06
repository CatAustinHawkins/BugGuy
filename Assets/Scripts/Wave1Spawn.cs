using System.Collections;
using UnityEngine;

public class Wave1Spawn : MonoBehaviour
{
    public GameObject Wave2Spawning;
    public int NormalEnemyCount;
    public GameObject[] Enemies;

    public int RandomCount;
    public GameObject WaveUI;

    public AudioSource WaveAudio;
    private void Start()
    {
        StartCoroutine(NormalEnemySpawn());
        WaveUI.SetActive(true);
        StartCoroutine(UIDelay());
        WaveAudio.Play();
    }

    void NormalEnemySpawning()
    {
        if (NormalEnemyCount < 5)
        {
            RandomCount = Random.Range(0, 3);
            Instantiate(Enemies[RandomCount], transform.position, transform.rotation);
            NormalEnemyCount++;

            StartCoroutine(NormalEnemySpawn());
        }

        if(NormalEnemyCount >= 5)
        {
            StartCoroutine(WaveEndPause());
        }
    }

    IEnumerator WaveEndPause()
    {
        yield return new WaitForSecondsRealtime(3f);
        Wave2Spawning.SetActive(true);
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
