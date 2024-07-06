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
    public bool OverTowerPlace5;
    public bool OverTowerPlace6;

    public GameObject NormalTurret1;
    public GameObject RocketTurret1;
    public GameObject SporeTurret1;
    public GameObject NormalTurret2;
    public GameObject RocketTurret2;
    public GameObject SporeTurret2;
    public GameObject NormalTurret3;
    public GameObject RocketTurret3;
    public GameObject SporeTurret3;
    public GameObject NormalTurret4;
    public GameObject RocketTurret4;
    public GameObject SporeTurret4;
    public GameObject NormalTurret5;
    public GameObject RocketTurret5;
    public GameObject SporeTurret5;
    public GameObject NormalTurret6;
    public GameObject RocketTurret6;
    public GameObject SporeTurret6;

    public GameObject OTower1;
    public GameObject OTower2;
    public GameObject OTower3;
    public GameObject OTower4;
    public GameObject OTower5;
    public GameObject OTower6;

    public GameObject TurretUI;

    public AudioSource TurretSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "TowerPlace1")
        {
            OverTowerPlace1 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace2")
        {
            OverTowerPlace2 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace3")
        {
            OverTowerPlace3 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace4")
        {
            OverTowerPlace4 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace5")
        {
            OverTowerPlace5 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace6")
        {
            OverTowerPlace6 = true;
            TurretUI.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "TowerPlace1")
        {
            OverTowerPlace1 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace2")
        {
            OverTowerPlace2 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace3")
        {
            OverTowerPlace3 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace4")
        {
            OverTowerPlace4 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace5")
        {
            OverTowerPlace5 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace6")
        {
            OverTowerPlace6 = false;
            TurretUI.SetActive(false);
        }
    }

    private void Update()
    {
        if(OverTowerPlace1)
        {
            if(Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret1.SetActive(true);
                OTower1.SetActive(false);
                TurretUI.SetActive(false);
                OverTowerPlace1 = false;
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret1.SetActive(true);
                OTower1.SetActive(false);
                OverTowerPlace1 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret1.SetActive(true);
                OTower1.SetActive(false);
                TurretUI.SetActive(false);
                OverTowerPlace1 = false;
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace2)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret2.SetActive(true);
                OTower2.SetActive(false);
                OverTowerPlace2 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret2.SetActive(true);
                OTower2.SetActive(false);
                OverTowerPlace2 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret2.SetActive(true);
                OTower2.SetActive(false);
                OverTowerPlace2 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace3)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret3.SetActive(true);
                OTower3.SetActive(false);
                OverTowerPlace3 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret3.SetActive(true);
                OTower3.SetActive(false);
                OverTowerPlace3 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret3.SetActive(true);
                OTower3.SetActive(false);
                TurretUI.SetActive(false);
                OverTowerPlace3 = false;
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace4)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret4.SetActive(true);
                OTower4.SetActive(false);
                TurretUI.SetActive(false);
                OverTowerPlace4 = false;
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret4.SetActive(true);
                OTower4.SetActive(false);
                OverTowerPlace4 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                SporeTurret4.SetActive(true);
                OTower4.SetActive(false);
                OverTowerPlace4 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace5)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret5.SetActive(true);
                OTower5.SetActive(false);
                TurretUI.SetActive(false);
                OverTowerPlace5 = false;
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret5.SetActive(true);
                OTower5.SetActive(false);
                OverTowerPlace5 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret5.SetActive(true);
                OTower5.SetActive(false);
                OverTowerPlace5 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace6)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret6.SetActive(true);
                OTower6.SetActive(false);
                OverTowerPlace6 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret6.SetActive(true);
                OTower6.SetActive(false);
                OverTowerPlace6 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret6.SetActive(true);
                OTower6.SetActive(false);
                OverTowerPlace6 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }
    }
}
