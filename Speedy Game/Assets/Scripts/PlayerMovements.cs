using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 startingPos;
    public float forwardForce = 3000f;
    public float xForce = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = startingPos;
    }

    // Update is called once per frame
    private void FixedUpdate() 
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        xControl();
    }

    private void xControl()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-xForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(xForce * Time.deltaTime, 0, 0);
        }
    }
}
