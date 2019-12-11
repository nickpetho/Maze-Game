using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTreasure : MonoBehaviour
{
    public TreasureData t;

    // Start is called before the first frame update
    void Start()
    {
        t.ResetCount();
    }

    // Update is called once per frame
    void Update()
    {
        //rotates 50 degrees per second around z axis
        transform.Rotate(0, 0, 50 * Time.deltaTime); 
    }

    void OnCollisionEnter(Collision col)
    {
        GameObject g = col.gameObject;
        if (g.CompareTag("Player"))
        {
            Destroy(gameObject);

            //Decrement treasure counter
            t.decrementCount();
        }
    }
}
