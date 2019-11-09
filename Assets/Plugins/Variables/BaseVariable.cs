using System;
using UnityEngine;

namespace Core.Variables
{
    public abstract class BaseVariable<T> : ScriptableObject, ISerializationCallbackReceiver
    {
        [SerializeField] T initialValue;

        [SerializeField] bool isConstant;

        public Action<T> onChange;
        
        T runtimeValue;

        public T Value
        {
            get => runtimeValue;
            set
            {
                if (isConstant)
                {
                    Debug.Log("Variable cannot be modified because it is marked as constant.", this);
                    return;
                }

                runtimeValue = value;
                
                onChange?.Invoke(runtimeValue);
            }
        }

        public void OnAfterDeserialize()
        {
            runtimeValue = initialValue;
        }

        public void OnBeforeSerialize() { }
    }
}