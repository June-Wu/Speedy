using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardSpeed;
    public float sideMoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate() 
    {
        Vector3 forwardMove = Vector3.forward * (Time.fixedDeltaTime * forwardSpeed);
        Vector3 sideMove = Vector3.right * (Input.GetAxis("Horizontal") * Time.fixedDeltaTime * sideMoveSpeed);
        rb.AddForce(forwardMove + sideMove);
        rb.MovePosition(rb.position + sideMove);
    }
}
