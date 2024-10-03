using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 10f;

    public float jumpHeight = 2000;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float moveHor = Input.GetAxis("Horizontal");
      rb.velocity = new Vector3(moveHor*speed, rb.velocity.y,0);
    if (input.GetKeyDown(KeyCode.Space))
    (
            rb.AddForce(Vector3.up*jumpHeight);
    )

    }
}
