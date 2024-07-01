using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 1f;
    public float range = 10f;

    public Camera MainCamera;

    public ParticleSystem test;

    public bool Cooldown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(MainCamera.transform.position, MainCamera.transform.forward, out hit, range) && !Cooldown)
        {
            test.Play();

            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if(target != null)
            {
                target.TakeDamage();
                StartCoroutine(Shooting());
            }
        }
    }

    IEnumerator Shooting()
    {
        Cooldown = true;
        yield return new WaitForSeconds(0.5f);
        Cooldown = false;
    }
}
