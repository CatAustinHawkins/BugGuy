using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{

    public GameObject[] SpeedPowerUps;

    public GameObject[] GunPowerUps;

    public float Random1;
    public int Random2;
    public float Random3;
    public float Random4;
    public void Start()
    {
        StartCoroutine(PowerUpSpawnerSpeed());
        StartCoroutine(PowerUpSpawnerGun());

    }

    IEnumerator PowerUpSpawnerSpeed()
    {
        Random1 = Random.Range(15, 45);
        Random4 = Random.Range(1, 3);
        yield return new WaitForSecondsRealtime(Random1);
        if(Random4 == 2)
        {
            Random2 = Random.Range(0, 7);
            SpeedPowerUps[Random2].SetActive(true);
        }
        StartCoroutine(PowerUpSpawnerSpeed());

    }

    IEnumerator PowerUpSpawnerGun()
    {
        Random4 = Random.Range(1, 3);
        Random3 = Random.Range(45, 90);
        yield return new WaitForSecondsRealtime(Random3);

        if (Random4 == 2)
        {
            Random2 = Random.Range(0, 6);
            GunPowerUps[Random2].SetActive(true);
        }

        StartCoroutine(PowerUpSpawnerGun());
    }
}
