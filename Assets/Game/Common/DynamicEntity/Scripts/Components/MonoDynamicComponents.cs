using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using Object = UnityEngine.Object;

public class MonoDynamicComponents : SerializedMonoBehaviour
{
    [SerializeField]
    private MonoDynamicEntity dynamicEntity;

    [SerializeField]
    private Component[] components;

    private void Awake()
    {
        foreach (var c in components)
        {           
            this.dynamicEntity.AddComponent(c.value);
        }
    }


    [Serializable]
    private struct Component 
    {
        [SerializeField]
        public Object value;
    }
}


