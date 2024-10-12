using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //Wave 1 - 5 Normal Enemies
    //Wave 2 - 10 
    //Wave 3 - 15

    //Wave 4 - 10 Light Enemies
    //Wave 5 - 10 Normal Enemies, 5 light enemies
    //Wave 6 - 10 normal enemies, 5 light enemies, 5 flying enemies
    //Wave 7 - 5 heavy enemies, 5 flying enemies
    //Wave 8 - 10 Normal Enemies, 5 heavy enemies, 5 flying enemies
    //wave 9 - 10 normal enemies, 5 flying enemies, 5 heavy, 5 light 
    //wave 10 - 10 heavy, 10 flying, 10 normal , boss


    public GameObject[] Enemies;

    public GameObject Wave1UI;
    public GameObject Wave2UI;
    public GameObject Wave3UI;
    public GameObject Wave4UI;
    public GameObject Wave5UI;
    public GameObject Wave6UI;
    public GameObject Wave7UI;
    public GameObject Wave8UI;
    public GameObject Wave9UI;
    public GameObject Wave10UI;

    public bool Wave1;
    public bool Wave2;
    public bool Wave3;
    public bool Wave4;
    public bool Wave5;
    public bool Wave6;
    public bool Wave7;
    public bool Wave8;
    public bool Wave9;
    public bool Wave10;
    public bool Wave11;

    public int NormalEnemyCount;
    public int HeavyEnemyCount;
    public int LightEnemyCount;
    public int FlyingEnemyCount;

    public bool BossSpawned;


    public int RandomCount;

    // Start is called before the first frame update
    void Start()
    {
        Wave1 = true;
        Wave1UI.SetActive(true);
        StartCoroutine(UIDelay());
    }


    public void Wave1Spawning()
    {
        if(NormalEnemyCount < 5 && Wave1)
        {
            StartCoroutine(NormalEnemySpawn());
        }

        if (NormalEnemyCount >= 5 && Wave1)
        {
            Wave1 = false;
            Wave2 = true;
        }
    }

    public void Wave2Spawning()
    {
        if (NormalEnemyCount < 10)
        {
            StartCoroutine(NormalEnemySpawn());
        }

        if (NormalEnemyCount >= 10)
        {
            Wave2 = false;
            Wave3 = true;
        }
    }

    public void Wave3Spawning()
    {
        if (NormalEnemyCount < 15)
        {
            StartCoroutine(NormalEnemySpawn());
        }

        if (NormalEnemyCount >= 15)
        {
            Wave3 = false;
            //Wave3 = true;
        }
    }

    IEnumerator NormalEnemySpawn()
    {
        RandomCount = Random.Range(1, 5);
        yield return new WaitForSecondsRealtime(RandomCount);
        Instantiate(Enemies[0], transform.position, transform.rotation);
        NormalEnemyCount++;
        RandomCount = Random.Range(1, 5);
        yield return new WaitForSecondsRealtime(RandomCount);
        Instantiate(Enemies[1], transform.position, transform.rotation);
        NormalEnemyCount++;
    }

    IEnumerator HeavyEnemySpawn()
    {
        RandomCount = Random.Range(1, 5);
        yield return new WaitForSecondsRealtime(RandomCount);
        Instantiate(Enemies[5], transform.position, transform.rotation);
        HeavyEnemyCount++;
    }

    IEnumerator FlyingEnemySpawn()
    {
        RandomCount = Random.Range(1, 5);
        yield return new WaitForSecondsRealtime(RandomCount);
        Instantiate(Enemies[4], transform.position, transform.rotation);
        FlyingEnemyCount++;
    }


    IEnumerator LightEnemySpawn()
    {
        RandomCount = Random.Range(1, 5);
        yield return new WaitForSecondsRealtime(RandomCount);
        Instantiate(Enemies[2], transform.position, transform.rotation);
        LightEnemyCount++;
        RandomCount = Random.Range(1, 5);
        yield return new WaitForSecondsRealtime(RandomCount);
        Instantiate(Enemies[3], transform.position, transform.rotation);
        LightEnemyCount++;
    }

    IEnumerator BossEnemySpawn()
    {
        RandomCount = Random.Range(1, 5);
        yield return new WaitForSecondsRealtime(RandomCount);
        Instantiate(Enemies[6], transform.position, transform.rotation);
        BossSpawned = true;
    }

    IEnumerator UIDelay()
    {
        yield return new WaitForSecondsRealtime(3f);

        if (Wave10)
        {
            Wave10UI.SetActive(false);
        }

        if (Wave10)
        {
            Wave9UI.SetActive(false);
            Wave10 = true;
            Wave9 = false;
        }

        if (Wave9)
        {
            Wave8UI.SetActive(false);
            Wave9 = true;
            Wave8 = false;
        }

        if (Wave8)
        {
            Wave7UI.SetActive(false);
            Wave8 = true;
            Wave7 = false;
        }

        if (Wave7)
        {
            Wave6UI.SetActive(false);
            Wave7 = true;
            Wave6 = false;
        }

        if (Wave6)
        {
            Wave5UI.SetActive(false);
            Wave6 = true;
            Wave5 = false;
        }

        if (Wave5)
        {
            Wave4UI.SetActive(false);
            Wave5 = true;
            Wave4 = false;
        }

        if (Wave4)
        {
            Wave3UI.SetActive(false);
            Wave4 = true;
            Wave3 = false;
        }

        if (Wave3)
        {
            Wave2UI.SetActive(false);
            Wave3 = true;
            Wave2 = false;
        }

        if (Wave2)
        {
            Wave1UI.SetActive(false);
            Wave1 = false;
        }
    }
}
