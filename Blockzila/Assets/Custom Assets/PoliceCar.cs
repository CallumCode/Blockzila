using UnityEngine;
using System.Collections;

public class PoliceCar : MonoBehaviour {


    NavMeshAgent navMeshAgent;
    public Transform target = null;
    // Use this for initialization
    void Start () {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update ()
    {

        if(target)
        {
            navMeshAgent.SetDestination(target.position);
        }

    }
}
