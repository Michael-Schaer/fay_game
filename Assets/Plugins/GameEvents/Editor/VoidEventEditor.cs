using Core.Events;
using UnityEditor;

namespace Core.GameEvents.Editor
{
    [CustomEditor(typeof(VoidEvent))]
    public class VoidEventEditor : BaseEventEditor<Void> { }
}