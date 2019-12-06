using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Animator animator;
    PlayerMovement playerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.isCaught)
        {
            Fade_Out();
        }
    }

    public void Fade_Out()
    {
        animator.SetBool("GameOver", playerScript.isCaught);
        Debug.Log(playerScript.isCaught);
    }
}
