using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent agent;

    PlayerMovement playerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        GetComponent<NavMeshAgent>().destination = player.transform.position;

        if (playerScript.isCaught)
        {
            GetComponent<NavMeshAgent>().isStopped = true;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        GameObject g = col.gameObject;
        if (g.CompareTag("Player"))
        {
            playerScript.isCaught = true;
            Debug.Log("Player Caught");
        }
    }
}
