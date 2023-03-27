using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;
    public Collider2D groundSensor = null;
    public LayerMask groundLayer = 0;
    public int jumpSpeed = 5;
    public int jumpCount = 2;

    public void moveLeft()
    {
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = -3;
        physicsBody.velocity = newVelocity;
    }

    public void moveRight()
    {
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = 3;
        physicsBody.velocity = newVelocity;
    }

    public void Jump()
    {
        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            Vector2 newVelocity = physicsBody.velocity;
            newVelocity.y = jumpSpeed;
            physicsBody.velocity = newVelocity;
        }
    }

    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
