using Core.Events;
using UnityEngine;

namespace Core.GameEvents.Editor
{
    public abstract class BaseEventEditor<T> : UnityEditor.Editor
    {
        protected BaseGameEvent<T> gameEvent;

        protected T value;

        protected virtual void Awake()
        {
            gameEvent = (BaseGameEvent<T>)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            ShowValueField();

            if (GUILayout.Button("Raise"))
            {
                gameEvent.Raise(value);
            }
        }

        protected virtual void ShowValueField() { }
    }
}