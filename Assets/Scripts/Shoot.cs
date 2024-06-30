using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;

    public bool Cooldown;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && !Cooldown)
        {
            GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, launchVelocity));
            StartCoroutine(Shooting());

        }
    }


    IEnumerator Shooting()
    {
        Cooldown = true;
        yield return new WaitForSeconds(0.5f);
        Cooldown = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
