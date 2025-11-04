using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;           // Speed of player movement
    public Rigidbody2D rb;                 // Reference to the Rigidbody2D component
    private Vector2 moveInput;             // Stores player input

    void Update()
    {
        // Get movement input from player
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize(); // Ensures consistent movement speed diagonally
    }

    void FixedUpdate()
    {
        // Apply movement to the Rigidbody2D
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }
}
