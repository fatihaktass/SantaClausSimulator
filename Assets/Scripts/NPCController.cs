using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{
    public Transform target;

    public NavMeshAgent agent;
    bool isChecking;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        isChecking = Physics2D.Raycast(transform.position, Vector2.one);
        if (!isChecking)
        {
            agent.SetDestination(target.position);
        }
        if (isChecking)
        {
            agent.SetDestination(transform.position);
        }
    }
}
