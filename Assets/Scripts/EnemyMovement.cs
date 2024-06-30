using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public GameObject PathEnd;
    public float speed;
    public string Path;

    // Start is called before the first frame update
    void Start()
    {
        PathEnd = GameObject.FindGameObjectWithTag(Path);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, PathEnd.transform.position, speed * Time.deltaTime);
    }
}
