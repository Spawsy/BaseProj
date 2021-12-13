using System;
using System.Collections.Generic;

public class ComponentBus
{
    private readonly Dictionary<Type, object> componentMap;

    public ComponentBus()
    {
        this.componentMap = new Dictionary<Type, object>();
    }

    public T GetComponent<T>()
    {
        var component = this.componentMap[typeof(T)];
        return (T) component;
    }

    public bool ContainsComponent<T>()
    {
        return this.componentMap.ContainsKey(typeof(T));
    }

    public void AddComponent(object value)
    {
        this.componentMap.Add(value.GetType(), value);
    }

    public void RemoveComponent<T>()
    {
        this.componentMap.Remove(typeof(T));
    }

    public bool TryGetComponent<T>(out T component)
    {
        if (this.componentMap.TryGetValue(typeof(T), out var comp))
        {
            component = (T)comp;
            return true;
        }

        component = default;
        return false;
    }
}
