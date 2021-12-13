using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GroundCheckCondition : IJumpCondition
{
    [SerializeField]
    MonoDynamicEntity player;
    [SerializeField]
    LayerMask mask;
    [SerializeField]
    float distance;
    public bool Check()
    {
        var transform = player.Transform;
        var hit = Physics2D.Raycast(transform.position, Vector2.down, distance, mask);
        if(hit)
            return true;
        return false;
    }
}
