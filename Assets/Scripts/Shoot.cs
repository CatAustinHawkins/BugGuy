using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;

    public bool Cooldown;

    public AudioSource GunShoot;

    private void Awake()
    {
        Cooldown = false;

    }

    private void OnEnable()
    {
        Cooldown = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && !Cooldown)
        {
            GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, launchVelocity));
            GunShoot.Play();
            StartCoroutine(Shooting());

        }
    }


    IEnumerator Shooting()
    {
        Cooldown = true;
        yield return new WaitForSeconds(0.18f);
        Cooldown = false;
    }

}
