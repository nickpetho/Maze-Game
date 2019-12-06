using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTreasure : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotates 50 degrees per second around y axis
        transform.Rotate(0, 50 * Time.deltaTime, 0); 
    }

    void OnCollisionEnter(Collision col)
    {
        GameObject g = col.gameObject;
        if (g.CompareTag("Player"))
        {
            Destroy(gameObject);

            //Decrement treasure counter
        }
    }
}
