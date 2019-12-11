using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public bool isCaught = false;
    public bool isWalking = false;
    public float speed = 5.0f;
    public float turnSpeed = 125.0f;
    private float horizontalInput;
    private float forwardInput;
    private Vector3 lastPosition;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isCaught)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

            //Move the player forward and backward based on vertical input
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

            //Move the player sideways based on horizontal input
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

            //Rotate the player to the right
            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            }

            if(lastPosition != transform.position){
                animator.SetBool("isWalking", true);
            }
            else{
                animator.SetBool("isWalking", false);
            }
        }

        lastPosition = transform.position;
    }

    void OnCollisionEnter(Collision col)
    {
        GameObject g = col.gameObject;
        if (g.CompareTag("Enemy"))
        {
            isCaught = true;
            //Debug.Log("Caught");

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
