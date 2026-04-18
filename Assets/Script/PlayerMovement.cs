using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;        // ความเร็วตัวละคร
    public Rigidbody2D rb;
    public Vector2 moveInput;

    void Update()
    {
        // รับ input จากปุ่ม WASD หรือ Arrow keys
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        // ป้องกันเดินเร็วขึ้นตอนเฉียง
        moveInput = moveInput.normalized;
        rb.linearVelocity = moveInput * speed;
    }
}