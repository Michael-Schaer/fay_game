using Core.Events;
using UnityEditor;

namespace Core.GameEvents.Editor
{
    [CustomEditor(typeof(IntEvent))]
    public class IntEventEditor : BaseEventEditor<int>
    {
        protected override void ShowValueField()
        {
            value = EditorGUILayout.IntField(value);
        }
    }
}