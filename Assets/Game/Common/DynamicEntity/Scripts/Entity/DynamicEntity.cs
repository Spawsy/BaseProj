using System;
using UnityEditor;
using UnityEngine;


public class DynamicEntity : IDynamicEntity
{
    private readonly ComponentBus components;

    public DynamicEntity()
    {
        components = new ComponentBus();
    }
    public void AddComponent(object component)
    {
        this.components.AddComponent(component);
    }

    public bool ContainsComponent<T>()
    {

        return this.components.ContainsComponent<T>();
    }

    public T GetComponent<T>()
    {
        return this.components.GetComponent<T>();
    }

    public void RemoveComponent<T>()
    {
        this.components.RemoveComponent<T>();
    }

    public bool TryGetComponent<T>(out T component)
    {
        return this.components.TryGetComponent<T>(out component);
    }
}