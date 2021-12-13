using Zenject;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;

//[ShowOdinSerializedPropertiesInInspector]
public class PlayerJumpController : SerializedMonoBehaviour
{
    [SerializeField]    
    private List<IJumpCondition> conditions;
    [Inject] private IJumpController jumpController;

    private void Awake()
    {

    }
    private void Update()
    {
        ProcessPlayerInput();
    }

    void ProcessPlayerInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            CheckCondotionsBeforeJump();
    }

    void CheckCondotionsBeforeJump()
    {
        foreach (var c in conditions)
            if (!c.Check())
                return;

        jumpController.Jump();
    }
    
}
