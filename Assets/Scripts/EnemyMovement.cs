using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public GameObject PathEnd;

    public GameObject PathStart;
    public float speed;
    public string Path;
    public string Path2;
    public bool Confused;

    // Start is called before the first frame update
    void Start()
    {
        PathEnd = GameObject.FindGameObjectWithTag(Path);
        PathStart = GameObject.FindGameObjectWithTag(Path2);
    }

    // Update is called once per frame
    void Update()
    {

        if (!Confused)
        {
            transform.position = Vector3.MoveTowards(transform.position, PathEnd.transform.position, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, PathStart.transform.position, speed * Time.deltaTime);
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Confuse")
        {
            Confused = true;
            StartCoroutine(ConfuseDelay());
        }
    }

    public void Confuse()
    {
        Confused = true;
    }

    IEnumerator ConfuseDelay()
    {
        yield return new WaitForSecondsRealtime(3f);
        Confused = false;       
}
}
