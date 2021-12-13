using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpWithRigidbody : MonoBehaviour, IJumpController
{

    [SerializeField] float jumpForce;
    [SerializeField] Rigidbody2D rb;
    public void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
