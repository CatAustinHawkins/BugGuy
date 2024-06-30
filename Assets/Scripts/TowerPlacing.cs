using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacing : MonoBehaviour
{
    public GameObject Player;
    public PlayerMisc PlayerScript;

    public bool OverTowerPlace1;
    public bool OverTowerPlace2;
    public bool OverTowerPlace3;
    public bool OverTowerPlace4;

    public GameObject Tower1;
    public GameObject Tower2;
    public GameObject Tower3;
    public GameObject Tower4;

    public GameObject OTower1;
    public GameObject OTower2;
    public GameObject OTower3;
    public GameObject OTower4;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "TowerPlace1")
        {
            OverTowerPlace1 = true;
        }

        if (other.tag == "TowerPlace2")
        {
            OverTowerPlace2 = true;
        }

        if (other.tag == "TowerPlace3")
        {
            OverTowerPlace3 = true;
        }

        if (other.tag == "TowerPlace4")
        {
            OverTowerPlace4 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "TowerPlace1")
        {
            OverTowerPlace1 = false;
        }

        if (other.tag == "TowerPlace2")
        {
            OverTowerPlace2 = false;
        }

        if (other.tag == "TowerPlace3")
        {
            OverTowerPlace3 = false;
        }

        if (other.tag == "TowerPlace4")
        {
            OverTowerPlace4 = false;
        }
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            if(OverTowerPlace1 && PlayerScript.Gold > 3f)
            {
                Tower1.SetActive(true);
                OTower1.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 4;
                OverTowerPlace1 = false;
            }

            if (OverTowerPlace2 && PlayerScript.Gold > 3f)
            {
                Tower2.SetActive(true);
                OTower2.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 4;
                OverTowerPlace2 = false;

            }

            if (OverTowerPlace3 && PlayerScript.Gold > 3f)
            {
                Tower3.SetActive(true);
                OTower3.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 4;
                OverTowerPlace3 = false;

            }

            if (OverTowerPlace4 && PlayerScript.Gold > 3f)
            {
                Tower4.SetActive(true);
                PlayerScript.Gold = PlayerScript.Gold - 4;
                OTower4.SetActive(false);
                OverTowerPlace4 = false;

            }
        }
    }
}
