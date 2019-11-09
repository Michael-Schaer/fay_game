using UnityEngine;
using UnityEngine.Events;

namespace Core.Events
{
    [CreateAssetMenu(menuName = "Events/Bool Event")]
    public class BoolEvent : BaseGameEvent<bool> { }

    [System.Serializable]
    public class UnityBoolEvent : UnityEvent<bool> { }
}