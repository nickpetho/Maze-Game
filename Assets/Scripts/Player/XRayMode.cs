using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRayMode : MonoBehaviour
{
    public bool pickupActive = false;
    public bool xRayMode = false;
    public float xRayModeDuration = 2.0f;
    float timer;
    float xRayModeStart;
    public Material[] material;
    GameObject[] walls;

    // Update is called once per frame
    void Update()
    {
        //Starts the cooldown timer for the players ability
        xRayModeStart += Time.deltaTime;

        if (pickupActive)
        {
            //Activates Ghost Mode if the cooldown has finished and the player presses space
            if (Input.GetKeyDown(KeyCode.LeftShift) && xRayModeStart > 5.0f)
            {
                xRayMode = true;

                //Changes the players color to GhostColor
                XRayVision(material[1]);
            }

            //Starts the timer to determine how long Ghost Mode is active for
            if (xRayMode)
            {
                timer += Time.deltaTime;
            }

            //Once the timer passes how long Ghost Mode can be on for, Ghost Mode is disabled
            if (timer > xRayModeDuration)
            {
                xRayMode = false;

                //Changes the players color back to normal
                XRayVision(material[0]);

                //Resets the timers
                timer = 0.0f;
                xRayModeStart = 0.0f;
            }
        }
    }

    public void XRayVision(Material m)
    {
        walls = GameObject.FindGameObjectsWithTag("InnerWall");

        foreach (GameObject wall in walls)
        {
            wall.GetComponent<Renderer>().sharedMaterial = m;
        }
    }
}
