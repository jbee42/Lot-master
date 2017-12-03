using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank1movement : MonoBehaviour {

    private Rigidbody2D rb;

    public KeyCode moveleft;
    public KeyCode moveright;
    public KeyCode rotateleft;
    public KeyCode rotateright;
    public KeyCode jump;

    public GameObject tankhead;

    public Transform groundCheck;
    public float groundRaidus = 0.2f;
    public bool grounded = false;
    public LayerMask whatIsGround;

    public float speed;
    public float rotationspeed = 2f;
    public float jumpForce;
 

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(rotateleft))
        {
            Rotateleft();
        }
        if (Input.GetKey(rotateright))
        {
            Rotateright();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRaidus, whatIsGround);
    }

    void Movement()
    {
        if (Input.GetKey(moveleft))
        {
            rb.velocity = Vector3.left * speed;
        }
        if (Input.GetKey(moveright))
        {
            rb.velocity = Vector3.right * speed;
        }
        if (Input.GetKey(jump) && grounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }

    private void Rotateright()
    {
        Vector3 rotation = tankhead.transform.localEulerAngles;
        rotation.z -= rotationspeed* Time.deltaTime;
        tankhead.transform.localEulerAngles = rotation;
    }

    private void Rotateleft()
    {
        Vector3 rotation = tankhead.transform.localEulerAngles;
        rotation.z += rotationspeed * Time.deltaTime;
        tankhead.transform.localEulerAngles = rotation;
    }
}
