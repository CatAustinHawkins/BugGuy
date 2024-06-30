using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

    public bool LargeEnemy;
    public bool MediumEnemy;
    public bool SmallEnemy;

    public float Health;

    public Slider HealthBar;

    public GameObject Player;
    public PlayerMisc PlayerScript;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerScript = Player.GetComponent<PlayerMisc>();

        if (LargeEnemy)
        {
            Health = 6;
            
        }

        if (MediumEnemy)
        {
            Health = 4;
        }

        if (SmallEnemy)
        {
            Health = 2;
        }
    }

    private void Update()
    {
        if(Health == 0)
        {
            Destroy(gameObject);
            PlayerScript.Gold++;

        }

        if (Health < 0)
        {
            Destroy(gameObject);
            PlayerScript.Gold++;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if(other.tag == "Bullet")
        {
            Health = Health - 1;
        }

        if(other.tag == "Home")
        {
            Destroy(gameObject);
        }
    }
}
