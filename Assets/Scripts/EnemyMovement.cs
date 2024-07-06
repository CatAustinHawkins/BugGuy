using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{

    public GameObject PathEnd;

    public GameObject PathStart;
    public string Path;
    public string Path2;
    public bool Confused;

    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        PathEnd = GameObject.FindGameObjectWithTag(Path);
        PathStart = GameObject.FindGameObjectWithTag(Path2);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Confused)
        {
            agent.SetDestination(PathEnd.transform.position);
        }
        else
        {
            agent.SetDestination(PathStart.transform.position);
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
