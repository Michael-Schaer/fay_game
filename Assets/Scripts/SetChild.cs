using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetChild : MonoBehaviour
{
    [SerializeField] private Transform childToAdd;

    public void Invoke()
    {
        childToAdd.transform.parent = transform;
    }
}
