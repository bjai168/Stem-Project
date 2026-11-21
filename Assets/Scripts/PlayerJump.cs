using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 12f;
    [Range(0f, 1f)]
    public float jumpCutMultiplier = 0.5f;

    public Transform groundCheck;
    public float checkRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);

        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            Debug.Log("A");
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(new Vector2(0, jumpForce));
    }
}
