using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public bool Cooldown;

    public float damage = 1f;
    public float range = 10f;

    public Camera MainCamera;

    public void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Shoot();
        }

    }

    public void Shoot()
    {
        if (!Cooldown)
        {
            RaycastHit hit;
            if (Physics.Raycast(MainCamera.transform.position, MainCamera.transform.forward, out hit, range) && !Cooldown)
            {
                EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
                if (target != null)
                {
                    target.TakeDamage();

                    StartCoroutine(Shooting());
                }
            }


        }

    }


    IEnumerator Shooting()
    {
        Cooldown = true;
        yield return new WaitForSeconds(0.15f);
        Cooldown = false;
    }
}

