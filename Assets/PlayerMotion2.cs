using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMotion2 : MonoBehaviour
{
    public NavMeshAgent agent;
    
    public NavMeshAgent agent2;

    public GameObject myCube;

    private Vector3 myCubePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myCubePos = myCube.transform.position;
        agent.SetDestination(myCubePos);
        agent2.SetDestination(agent.transform.position);
    }
}
