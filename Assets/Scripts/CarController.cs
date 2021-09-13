using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float moveInput;
    private float turnInput;
    private bool isCarGrounded;

    public float airDrag;
    public float groundDrag;

    public float revSpeed;
    public float fwdSpeed;
    public float turnSpeed;
    public LayerMask groundLayer;

    public Rigidbody sphereRB;

    void Start()
    {
        sphereRB.transform.parent = null;
    }

    
    void Update()
    {
        moveInput = Input.GetAxisRaw("Vertical");
        turnInput = Input.GetAxisRaw("Horizontal");

        moveInput *= moveInput > 0 ? fwdSpeed : revSpeed;

        transform.position = sphereRB.transform.position;

        float newRotation = turnInput * turnSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical");
        transform.Rotate(0, newRotation,0 , Space.World);

        RaycastHit hit;
        isCarGrounded = Physics.Raycast(origin: transform.position, direction: -transform.up, out hit,maxDistance: 1f, groundLayer);

        transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;

        if(isCarGrounded)
        {
            sphereRB.drag = groundDrag;
        }
        else
        {
            sphereRB.drag = airDrag;
        }
    }

    private void FixedUpdate()
    {
        if(isCarGrounded)
        {
            sphereRB.AddForce(transform.forward * moveInput, ForceMode.Acceleration);
        }
        else 
        {
            sphereRB.AddForce(transform.up * -30f); 
        }
    }
}
