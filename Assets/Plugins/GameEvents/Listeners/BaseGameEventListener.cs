using UnityEngine;
using UnityEngine.Events;

namespace Core.Events
{
    public abstract class BaseGameEventListener<T, E, UER> : MonoBehaviour,
        IGameEventListener<T> where E : BaseGameEvent<T> where UER : UnityEvent<T>
    {
        [SerializeField]
        E gameEvent;

        public E GameEvent
        {
            get { return gameEvent; }
            set { gameEvent = value; }
        }

        [SerializeField]
        public UER unityEventResponse;

        void OnEnable()
        {
            if (gameEvent == null)
                return;

            GameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (gameEvent == null)
                return;

            GameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T item)
        {
            if (unityEventResponse == null)
                return;

            unityEventResponse.Invoke(item);
        }
    }
}