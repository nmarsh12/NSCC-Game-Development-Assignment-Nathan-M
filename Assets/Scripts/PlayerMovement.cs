using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputActionReference moveInput;

    private Vector2 moveDirection;
    private Vector3 inputVector;
    public float moveSpeed;
    public float maxVelocity;
    float baseTurnSpeed;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = moveInput.action.ReadValue<Vector2>();
        inputVector = new Vector3(moveDirection.x, 0, moveDirection.y);
    }

    void FixedUpdate() {
        Move();
    }

    void Move() {
        rb.AddForce(transform.right * moveDirection.x * moveSpeed, ForceMode.Acceleration);
        rb.AddForce(transform.forward * moveDirection.y * moveSpeed, ForceMode.Acceleration);
    }
/*
    void VelocityDirection() {
        float velocityMagnitude = Mathf.Sqrt(rb.velocity.x*rb.velocity.x + rb.velocity.z*rb.velocity.z);
        Vector3 localVelocity = transform.InverseTransformDirection(rb.velocity);
        rb.velocity = Vector3.RotateTowards(localVelocity, moveDirection, 2f, 2f);
    }
*/
    void Accelerate() {

    }
}
