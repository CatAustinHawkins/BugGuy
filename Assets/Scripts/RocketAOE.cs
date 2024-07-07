using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketAOE : MonoBehaviour
{
    //if enemy is shot
    //hit the other enemies in range

    public List<GameObject> EnemiesInRange;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            EnemiesInRange.Add(other.gameObject);
            Shot();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            EnemiesInRange.Remove(other.gameObject);
        }
    }

    public void Shot()
    {

        for (int i = 0; i < EnemiesInRange.Count; i++)
        {
            EnemiesInRange[i].GetComponent<EnemyHealth>().TakeDamage();
        }
    }

}
