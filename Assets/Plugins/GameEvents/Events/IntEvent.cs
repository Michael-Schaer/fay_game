using UnityEngine;
using UnityEngine.Events;

namespace Core.Events
{
    [CreateAssetMenu(menuName = "Events/Int Event")]
    public class IntEvent : BaseGameEvent<int> { }

    [System.Serializable]
    public class UnityIntEvent : UnityEvent<int> { }
}