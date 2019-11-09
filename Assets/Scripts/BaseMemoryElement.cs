using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMemoryElement : MonoBehaviour
{
    public abstract void Initialize();

    internal void Finish()
    {
        MemoryManager.Instance.Next();
    }
}