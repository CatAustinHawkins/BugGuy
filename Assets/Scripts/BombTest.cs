using UnityEngine;

public class BombTest : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.B))
        {
            GameObject[] gos = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject go in gos)
                Destroy(go);
        }
    }
}
