using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMode : MonoBehaviour
{
    public bool pickupActive = false;
    public bool ghostMode = false;
    public float ghostModeDuration = 1.0f;
    public float ghostModeStart;
    float timer;
    Rigidbody rb;
    Collider playerCollider;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the players collider, rigidbody, and renderer components
        playerCollider = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
        ghostModeStart = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (pickupActive)
        {
            //Starts the cooldown timer for the players ability
            ghostModeStart += Time.deltaTime;

            //Activates Ghost Mode if the cooldown has finished and the player presses space
            if (Input.GetKeyDown("space") && ghostModeStart > 4.0f)
            {
                ghostMode = true;

                //Turns off the players collider
                playerCollider.enabled = !playerCollider.enabled;

                //Turns off gravity for the player (so they do not fall through the map)
                rb.useGravity = false;

                //Reset the timer
                ghostModeStart = 0.0f;
            }

            //Starts the timer to determine how long Ghost Mode is active for
            if (ghostMode)
            {
                timer += Time.deltaTime;
            }

            //Once the timer passes how long Ghost Mode can be on for, Ghost Mode is disabled
            if (timer > ghostModeDuration)
            {
                ghostMode = false;

                //Turns on the players collider
                playerCollider.enabled = true;

                //Turns on gravity for the player
                rb.useGravity = true;

                //Resets the timer
                timer = 0.0f;
            }
        }
    }
}
