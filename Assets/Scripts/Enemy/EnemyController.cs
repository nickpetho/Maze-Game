using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent agent;
    PlayerMovement playerScript;
    GameManager gameScript;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
        gameScript = FindObjectOfType<GameManager>().GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        GetComponent<NavMeshAgent>().destination = player.transform.position;

        if (gameScript.GameHasEnded)
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
        }
    }
}
