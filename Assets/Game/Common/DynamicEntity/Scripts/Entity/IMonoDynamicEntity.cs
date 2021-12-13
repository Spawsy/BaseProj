using System.Collections;
using UnityEngine;


public interface IMonoDynamicEntity : IDynamicEntity
{
    GameObject GameObject { get; }
    Transform Transform { get; }

}
