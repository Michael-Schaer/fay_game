using System.Collections.Generic;
using UnityEngine;

namespace Core.Events
{
    public abstract class BaseGameEvent<T> : ScriptableObject
    {
        readonly List<IGameEventListener<T>> listeners = new List<IGameEventListener<T>>();

        public void Raise(T item)
        {
            for (int i = listeners.Count - 1; i >= 0; --i)
            {
                listeners[i].OnEventRaised(item);
            }
        }

        public void RegisterListener(IGameEventListener<T> listener)
        {
            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener<T> listener)
        {
            listeners.Remove(listener);
        }
    }
}