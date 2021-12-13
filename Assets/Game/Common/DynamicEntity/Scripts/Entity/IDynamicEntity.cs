using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDynamicEntity
{
    T GetComponent<T>();

    bool ContainsComponent<T>();

    bool TryGetComponent<T>(out T component);

    void AddComponent(object component);

    void RemoveComponent<T>();
}
