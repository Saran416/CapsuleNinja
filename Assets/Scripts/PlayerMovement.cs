using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpforce = 5f;

    [SerializeField] Transform groundcheck;
    [SerializeField] LayerMask ground;
    // Start is called before the first frame update    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");
        rb.velocity= new Vector3(speed*horizontalinput,rb.velocity.y,speed*verticalinput);
        if(Input.GetButtonDown("Jump") && IsGrounded()){
            rb.velocity = new Vector3(rb.velocity.x,jumpforce,rb.velocity.z);
        }
    }

    bool IsGrounded(){
        return Physics.CheckSphere(groundcheck.position, 0.1f, ground);
    }
}
