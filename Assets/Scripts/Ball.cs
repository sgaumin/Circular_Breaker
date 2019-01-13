using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = moveSpeed * -transform.up;
    }

    private void FixedUpdate()
    {
        rb.velocity = moveSpeed * (rb.velocity.normalized);
    }
}
