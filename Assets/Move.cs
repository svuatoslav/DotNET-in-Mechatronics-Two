using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    [SerializeField] private Transform[] ways = null;

    private int currentPoint = 0;
    private NavMeshAgent navMeshAgent = null;
    private void Awake()
    {
        navMeshAgent= GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            currentPoint = (currentPoint + 1) % ways.Length;
            navMeshAgent.SetDestination(ways[currentPoint].position);
        }
    }
    private void Start()
    {
        navMeshAgent.SetDestination(ways[0].position);
    }
}
