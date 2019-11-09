using UnityEngine;
using UnityEngine.Events;

namespace Core.Events
{
    [CreateAssetMenu(menuName = "Events/String Event")]
    public class StringEvent : BaseGameEvent<string> { }

    [System.Serializable]
    public class UnityStringEvent : UnityEvent<string> { }
}