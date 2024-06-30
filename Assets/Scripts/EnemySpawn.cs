using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject Enemy1;
    public GameObject Enemy2;

    public float RandomValue;
    public float RandomValue2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemySpawning()
    {
        RandomValue = Random.Range(3, 15);

        RandomValue2 = Random.Range(1, 3);

        if(RandomValue2 == 1)
        {
            GameObject enemy = Instantiate(Enemy1, transform.position, transform.rotation);
        }
        else
        {
            GameObject enemy = Instantiate(Enemy2, transform.position, transform.rotation);
        }

        yield return new WaitForSeconds(RandomValue);
        StartCoroutine(EnemySpawning());
    }
}
