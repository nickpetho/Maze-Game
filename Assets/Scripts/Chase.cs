using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    // How fast the object moves move per second
    public float speed = 0.04f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Get reference to target object by looking for an object with that tag.
        GameObject targetObject = GameObject.FindGameObjectWithTag("Player");

        // Get the players location
        float tx = targetObject.transform.position.x;
        float ty = targetObject.transform.position.y;
        float tz = targetObject.transform.position.z;

        // Get my position
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        // Determine my distance to target in each dimension
        float dx = tx - x;
        float dy = ty - y;
        float dz = tz - z;

        // Create new Vector3 based on magnitude of distance in each direction
        Vector3 movement = new Vector3(dx, dy, dz);

        // Normalize the total size of the vector to the desired speed.
        // This insures that the total speed in space is that speed.
        Vector3 movementNormalized = Vector3.ClampMagnitude(movement, speed);

        // Increment the position by the normalized movement
        transform.position += movementNormalized;

        // Create vector for target position (necessary for facing script)
        Vector3 targetVector = new Vector3(tx, ty, tz);

        // Call script to face in direction of target position
        transform.LookAt(targetVector);
    }
}
