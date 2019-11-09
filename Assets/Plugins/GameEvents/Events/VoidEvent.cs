using UnityEngine;
using UnityEngine.Events;

namespace Core.Events
{
    [CreateAssetMenu(menuName = "Events/Void Event")]
    public class VoidEvent : BaseGameEvent<Void>
    {
        public void Raise() => Raise(new Void());
    }

    [System.Serializable]

    public class UnityVoidEvent : UnityEvent<Void> { }
}