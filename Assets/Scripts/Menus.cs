using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public bool MainMenu;
    public bool TutorialPlayer;
    public bool TutorialEnemy;
    public bool TutorialTurret;
    public bool Level;
    public bool Lost;
    public bool Win;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(MainMenu)
            {
                SceneManager.LoadScene("TutorialPlayer");
            }

            if (TutorialTurret)
            {
                SceneManager.LoadScene("Level");
            }

            if (Lost || Win)
            {
                SceneManager.LoadScene("MainMenu");
            }

            if (TutorialPlayer)
            {
                SceneManager.LoadScene("TutorialEnemy");
            }

            if (TutorialEnemy)
            {
                SceneManager.LoadScene("TutorialTurrets");
            }
        }


        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }    
    }



}
