using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public GhostData g;
    GhostMode ghostModeScript;

    // Start is called before the first frame update
    void Start()
    {
        ghostModeScript = GameObject.FindWithTag("Player").GetComponent<GhostMode>();
    }


    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        GameObject e = (GameObject)Instantiate(pickupEffect, transform.position, transform.rotation);
        Destroy(e, 1.5f);

        ghostModeScript.pickupActive = true;

        //Decrement powerup counter
        g.decrementCount();

        Destroy(this.gameObject);
    }
}
