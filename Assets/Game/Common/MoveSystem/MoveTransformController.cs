using UnityEditor;
using UnityEngine;


public class MoveTransformController : MonoBehaviour, IMoveController
{
    [SerializeField] private float speed;
    [SerializeField] private Transform moveTransform;

    private float fixedDeltaTime;

    private void Awake()
    {
        fixedDeltaTime = Time.deltaTime;
    }

    public void Move(float direction)
    {
        Debug.Log(direction);
        moveTransform.position += new Vector3(speed * fixedDeltaTime * direction, 0f, 0f);
    }
}
