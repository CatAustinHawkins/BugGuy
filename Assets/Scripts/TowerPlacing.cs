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
    public bool OverTowerPlace7;
    public bool OverTowerPlace8;
    public bool OverTowerPlace9;
    public bool OverTowerPlace10;
    public bool OverTowerPlace11;
    public bool OverTowerPlace12;
    public bool OverTowerPlace13;
    public bool OverTowerPlace14;
    public bool OverTowerPlace15;

    public GameObject[] NormalTurret;
    public GameObject[] RocketTurret;
    public GameObject[] SporeTurret;

    public GameObject[] OTower;

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

        if (other.tag == "TowerPlace7")
        {
            OverTowerPlace7 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace8")
        {
            OverTowerPlace8 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace9")
        {
            OverTowerPlace9 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace10")
        {
            OverTowerPlace10 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace11")
        {
            OverTowerPlace11 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace12")
        {
            OverTowerPlace12 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace13")
        {
            OverTowerPlace13 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace14")
        {
            OverTowerPlace14 = true;
            TurretUI.SetActive(true);
        }

        if (other.tag == "TowerPlace15")
        {
            OverTowerPlace15 = true;
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

        if (other.tag == "TowerPlace7")
        {
            OverTowerPlace7 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace8")
        {
            OverTowerPlace8 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace9")
        {
            OverTowerPlace9 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace10")
        {
            OverTowerPlace10 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace11")
        {
            OverTowerPlace11 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace12")
        {
            OverTowerPlace12 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace13")
        {
            OverTowerPlace13 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace14")
        {
            OverTowerPlace14 = false;
            TurretUI.SetActive(false);
        }

        if (other.tag == "TowerPlace15")
        {
            OverTowerPlace15 = false;
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
                NormalTurret[0].SetActive(true);
                OTower[0].SetActive(false);
                TurretUI.SetActive(false);
                OverTowerPlace1 = false;
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[0].SetActive(true);
                OTower[0].SetActive(false);
                OverTowerPlace1 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[0].SetActive(true);
                OTower[0].SetActive(false);
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
                NormalTurret[1].SetActive(true);
                OTower[1].SetActive(false);
                OverTowerPlace2 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[1].SetActive(true);
                OTower[1].SetActive(false);
                OverTowerPlace2 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[1].SetActive(true);
                OTower[1].SetActive(false);
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
                NormalTurret[2].SetActive(true);
                OTower[2].SetActive(false);
                OverTowerPlace3 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[2].SetActive(true);
                OTower[2].SetActive(false);
                OverTowerPlace3 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[2].SetActive(true);
                OTower[2].SetActive(false);
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
                NormalTurret[3].SetActive(true);
                OTower[3].SetActive(false);
                TurretUI.SetActive(false);
                OverTowerPlace4 = false;
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[3].SetActive(true);
                OTower[3].SetActive(false);
                OverTowerPlace4 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                SporeTurret[3].SetActive(true);
                OTower[3].SetActive(false);
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
                NormalTurret[4].SetActive(true);
                OTower[4].SetActive(false);
                TurretUI.SetActive(false);
                OverTowerPlace5 = false;
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[4].SetActive(true);
                OTower[4].SetActive(false);
                OverTowerPlace5 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[4].SetActive(true);
                OTower[4].SetActive(false);
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
                NormalTurret[5].SetActive(true);
                OTower[5].SetActive(false);
                OverTowerPlace6 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[5].SetActive(true);
                OTower[5].SetActive(false);
                OverTowerPlace6 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[5].SetActive(true);
                OTower[5].SetActive(false);
                OverTowerPlace6 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace7)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret[6].SetActive(true);
                OTower[6].SetActive(false);
                OverTowerPlace7 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[6].SetActive(true);
                OTower[6].SetActive(false);
                OverTowerPlace7 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[6].SetActive(true);
                OTower[6].SetActive(false);
                OverTowerPlace7 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace8)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret[7].SetActive(true);
                OTower[7].SetActive(false);
                OverTowerPlace8 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[7].SetActive(true);
                OTower[7].SetActive(false);
                OverTowerPlace8 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[7].SetActive(true);
                OTower[7].SetActive(false);
                OverTowerPlace8 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace9)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret[8].SetActive(true);
                OTower[8].SetActive(false);
                OverTowerPlace9 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[8].SetActive(true);
                OTower[8].SetActive(false);
                OverTowerPlace9 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[8].SetActive(true);
                OTower[8].SetActive(false);
                OverTowerPlace9 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace10)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret[9].SetActive(true);
                OTower[9].SetActive(false);
                OverTowerPlace10 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[9].SetActive(true);
                OTower[9].SetActive(false);
                OverTowerPlace10 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[9].SetActive(true);
                OTower[9].SetActive(false);
                OverTowerPlace10 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace11)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret[10].SetActive(true);
                OTower[10].SetActive(false);
                OverTowerPlace11 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[10].SetActive(true);
                OTower[10].SetActive(false);
                OverTowerPlace11 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[10].SetActive(true);
                OTower[10].SetActive(false);
                OverTowerPlace11 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace12)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret[11].SetActive(true);
                OTower[11].SetActive(false);
                OverTowerPlace12 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[11].SetActive(true);
                OTower[11].SetActive(false);
                OverTowerPlace12 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[11].SetActive(true);
                OTower[11].SetActive(false);
                OverTowerPlace12 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace13)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret[12].SetActive(true);
                OTower[12].SetActive(false);
                OverTowerPlace13 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[12].SetActive(true);
                OTower[12].SetActive(false);
                OverTowerPlace13 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[12].SetActive(true);
                OTower[12].SetActive(false);
                OverTowerPlace13 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace14)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret[13].SetActive(true);
                OTower[13].SetActive(false);
                OverTowerPlace14 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[13].SetActive(true);
                OTower[13].SetActive(false);
                OverTowerPlace14 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[13].SetActive(true);
                OTower[13].SetActive(false);
                OverTowerPlace14 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }

        if (OverTowerPlace15)
        {
            if (Input.GetKey(KeyCode.Alpha1) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                NormalTurret[14].SetActive(true);
                OTower[14].SetActive(false);
                OverTowerPlace15 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha2) && PlayerScript.Gold >= 10)
            {
                TurretSpawn.Play();
                RocketTurret[14].SetActive(true);
                OTower[14].SetActive(false);
                OverTowerPlace15 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 10;
            }

            if (Input.GetKey(KeyCode.Alpha3) && PlayerScript.Gold >= 5)
            {
                TurretSpawn.Play();
                SporeTurret[14].SetActive(true);
                OTower[14].SetActive(false);
                OverTowerPlace15 = false;
                TurretUI.SetActive(false);
                PlayerScript.Gold = PlayerScript.Gold - 5;
            }
        }
    }
}
