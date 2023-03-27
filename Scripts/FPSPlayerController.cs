using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSPlayerController : MonoBehaviour
{
    public float speed;
    public float sprint;
    public float maxForce;
    public float jumpForce;

    public Transform groundCheck;
    public float groundDistance;
    public LayerMask groundMask;

    public Transform camHolder;
    public float sensitivity;
    public Vector2 viewAngle;

    private Rigidbody rb;
    private bool isGrounded;
    private float lookRotation;
    private float velocity;

    private void Start() 
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() 
    {
        Movement();
    }

    private void LateUpdate() 
    {
        Rotation();
    }

    private void Movement()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        Vector3 currentVelocity = rb.velocity;
        Vector3 targetVelocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if(Input.GetAxis("Fire3") > 0)
        {
            velocity = speed + sprint;
        }
        else
        {
            velocity = speed;
        }

        targetVelocity *= velocity;

        if(Input.GetAxis("Jump") > 0 && isGrounded)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }

        targetVelocity = transform.TransformDirection(targetVelocity);

        Vector3 velocityChange = (targetVelocity - currentVelocity);
        velocityChange = new Vector3(velocityChange.x, 0, velocityChange.z);
        
        Vector3.ClampMagnitude(velocityChange, maxForce);

        rb.AddForce(velocityChange, ForceMode.VelocityChange);
    }

    private void Rotation() 
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * sensitivity);

        lookRotation += -Input.GetAxis("Mouse Y") * sensitivity;
        lookRotation = Mathf.Clamp(lookRotation, viewAngle.x, viewAngle.y);
        camHolder.transform.eulerAngles = new Vector3(lookRotation, camHolder.transform.eulerAngles.y, camHolder.transform.eulerAngles.z);
    }
}
