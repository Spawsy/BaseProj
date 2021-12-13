using System.Collections;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Diagnostics;
using System.Collections.Generic;
using System;

public class MonoDynamicEntity : SerializedMonoBehaviour, IMonoDynamicEntity
{
    [ShowInInspector]
    private readonly DynamicEntity dynamicEntity;
    public GameObject GameObject => this.gameObject;

    public Transform Transform => this.transform;

    public MonoDynamicEntity()
    {
        this.dynamicEntity = new DynamicEntity();
    }

    public void AddComponent(object component)
    {
        this.dynamicEntity.AddComponent(component);
    }

    public bool ContainsComponent<T>()
    {
        return this.dynamicEntity.ContainsComponent<T>();
    }

    public new T GetComponent<T>()
    {
        return this.dynamicEntity.GetComponent<T>();
    }

    public void RemoveComponent<T>()
    {
        this.dynamicEntity.RemoveComponent<T>();
    }

    public new bool TryGetComponent<T>(out T component)
    {
        return this.dynamicEntity.TryGetComponent<T>(out component);
    }
}
