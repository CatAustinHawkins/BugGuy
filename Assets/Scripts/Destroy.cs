using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject tobedestroyed;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            tobedestroyed.SetActive(false);
        }
    }
}
