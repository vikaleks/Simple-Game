using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject player;
    Transform playerTR;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerTR = player.GetComponent<Transform>();       
    }

    void Update()
    {
        agent.SetDestination(playerTR.position);
    }
}
