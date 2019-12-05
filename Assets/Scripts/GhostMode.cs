using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMode : MonoBehaviour
{
    private bool ghostMode = false;
    public float ghostModeDuration = 1.0f;
    float timer;
    float ghostModeStart;
    public Material[] material;
    Rigidbody rb;
    Renderer rend;
    Collider playerCollider;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the players collider, rigidbody, and renderer components
        playerCollider = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();

        //Sets the material to the base material
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        //Starts the cooldown timer for the players ability
        ghostModeStart += Time.deltaTime;

        //Activates Ghost Mode if the cooldown has finished and the player presses space
        if (Input.GetKeyDown("space") && ghostModeStart > 2.0f)
        {
            ghostMode = true;

            //Turns off the players collider
            playerCollider.enabled = !playerCollider.enabled;

            //Changes the players color to GhostColor
            rend.sharedMaterial = material[1];

            //Turns off gravity for the player (so they do not fall through the map)
            rb.useGravity = false;
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

            //Changes the players color back to normal
            rend.sharedMaterial = material[0];

            //Turns on gravity for the player
            rb.useGravity = true;

            //Resets the timers
            timer = 0.0f;
            ghostModeStart = 0.0f;
        }
    }
}
