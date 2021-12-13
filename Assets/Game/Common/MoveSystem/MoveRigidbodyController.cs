using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigidbodyController : MonoBehaviour, IMoveController
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D moveRigidbody;

    private float fixedDeltaTime;

    private void Awake()
    {
        fixedDeltaTime = Time.deltaTime;
    }

    public void Move(float direction)
    {
        moveRigidbody.velocity = new Vector2(speed * direction, moveRigidbody.velocity.y);
    }
}
