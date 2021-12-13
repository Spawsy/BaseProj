using System.Collections;
using Zenject;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    [Inject] private IMoveController moveController;

    private float moveDirection;

    private void Update()
    {
        ProcessPlayerInput();
    }

    private void FixedUpdate()
    {
        moveController.Move(moveDirection);
    }

    private void ProcessPlayerInput()
    {
        moveDirection = 0;
        moveDirection = Input.GetAxis("Horizontal");
    }
}
