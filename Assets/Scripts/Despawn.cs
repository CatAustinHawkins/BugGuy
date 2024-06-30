using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Cooldown());
    }


    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(gameObject);

        }
    }
}
