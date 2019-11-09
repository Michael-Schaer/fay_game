using UnityEngine;
using UnityEngine.Events;

namespace Core.Events
{
    [CreateAssetMenu(menuName = "Events/Float Event")]
    public class FloatEvent : BaseGameEvent<float> { }

    [System.Serializable]
    public class UnityFloatEvent : UnityEvent<float> { }
}