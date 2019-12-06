using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRayPowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public XRayData x;
    XRayMode xrayModeScript;

    // Start is called before the first frame update
    void Start()
    {
        xrayModeScript = GameObject.FindWithTag("Player").GetComponent<XRayMode>();
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

        xrayModeScript.pickupActive = true;

        //Decrement powerup counter
        x.decrementCount();

        Destroy(this.gameObject);
    }
}
