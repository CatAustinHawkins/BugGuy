using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDie : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Lost");
        }
    }
}
