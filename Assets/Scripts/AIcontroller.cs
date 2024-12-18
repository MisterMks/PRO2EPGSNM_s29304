using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIcontroller : MonoBehaviour
{
    public NavMeshAgent agent;
    Animator anim;
    SpriteRenderer sr;

    public Transform point1;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
        sr = GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        if(point1 == null)
        { 
            return;
        }

        agent.SetDestination(point1.position);

        if (agent.velocity.magnitude <= 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
    }
}
