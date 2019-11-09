using Core.Events;
using UnityEditor;

namespace Core.GameEvents.Editor
{
    [CustomEditor(typeof(FloatEvent))]
    public class FloatEventEditor : BaseEventEditor<float>
    {
        protected override void ShowValueField()
        {
            value = EditorGUILayout.FloatField(value);
        }
    }
}