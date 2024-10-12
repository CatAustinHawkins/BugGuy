using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EnemyHealth : MonoBehaviour
{
    public bool LargeEnemy;
    public bool MediumEnemy;
    public bool SmallEnemy;
    public bool Moth;
    public float Health;
    public bool Boss;
    public Slider HealthBar;

    public GameObject Player;
    public PlayerMisc PlayerScript;
    public List<GameObject> EnemiesInRange;

    public SpriteRenderer EnemySprite;

    public GameObject GOAudio1;
    public GameObject GOAudio2;
    public GameObject GOAudio3;
    public GameObject GOAudio4;
    public GameObject GOAudio5;

    public AudioSource EnemyHurt1;
    public AudioSource EnemyHurt2;
    public AudioSource GoldCollect;
    public AudioSource EnemySpeak1;
    public AudioSource EnemySpeak2;

    public int RandomInt;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerScript = Player.GetComponent<PlayerMisc>();

        GOAudio1 = GameObject.FindGameObjectWithTag("EnemyHurt1");
        EnemyHurt1 = GOAudio1.GetComponent<AudioSource>();

        GOAudio2 = GameObject.FindGameObjectWithTag("EnemyHurt2");
        EnemyHurt2 = GOAudio1.GetComponent<AudioSource>();

        GOAudio3 = GameObject.FindGameObjectWithTag("GoldCollect");
        GoldCollect = GOAudio3.GetComponent<AudioSource>();

        GOAudio4 = GameObject.FindGameObjectWithTag("EnemySpeak1");
        EnemySpeak1 = GOAudio4.GetComponent<AudioSource>();

        GOAudio5 = GameObject.FindGameObjectWithTag("EnemySpeak2");
        EnemySpeak2 = GOAudio5.GetComponent<AudioSource>();

        if (!Moth)
        {
            EnemySprite = gameObject.GetComponent<SpriteRenderer>();
        }

        if(Boss)
        {
            Health = 130;
        }

        if (LargeEnemy)
        {
            Health = 40;
        }

        if(Moth)
        {
            Health = 12;
        }

        if (MediumEnemy)
        {
            Health = 8;
        }

        if (SmallEnemy)
        {
            Health = 8;
        }
    }

    private void Update()
    {
        if (Health <= 0)
        {
            if (Boss)
            {
                SceneManager.LoadScene("Won");
            }
            Destroy(gameObject);
            PlayerScript.Gold+=2;
            GoldCollect.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if(other.tag == "Bullet")
        {
            TakeDamage();
        }

        if(other.tag == "Home")
        {
            Destroy(gameObject);
        }

        if (other.tag == "Player")
        {
            RandomInt = Random.Range(0, 3);

            if (RandomInt == 1)
            {
                EnemySpeak1.Play();

            }
            else
            {
                EnemySpeak2.Play();

            }
        }

        if (other.tag == "Enemy")
        {
            Debug.Log(other.gameObject + "Added");
            EnemiesInRange.Add(other.gameObject);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            EnemiesInRange.Remove(other.gameObject);
        }
    }

    public void TakeDamage()
    {
        Health = Health - 0.3f;
        EnemySprite.color = Color.red;
        StartCoroutine(EnemyHit());
        RandomInt = Random.Range(0, 3);

        if(RandomInt == 1)
        {
            EnemyHurt1.Play();

        }
        else
        {
            EnemyHurt2.Play();

        }
    }

    public void Shot()
    {
        for (int i = 0; i < EnemiesInRange.Count; i++)
        {
            EnemiesInRange[i].GetComponent<EnemyHealth>().TakeDamage();
        }
    }

    IEnumerator EnemyHit()
    {
        yield return new WaitForSecondsRealtime(0.05f);
        EnemySprite.color = Color.white;
    }
}
