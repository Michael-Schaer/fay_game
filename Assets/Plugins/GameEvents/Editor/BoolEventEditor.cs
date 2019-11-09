using Core.Events;
using UnityEditor;
using UnityEngine;

namespace Core.GameEvents.Editor
{
    [CustomEditor(typeof(BoolEvent))]
    public class BoolEventEditor : BaseEventEditor<bool>
    {
        protected override void ShowValueField()
        {
            value = GUILayout.Toggle(value, "");
        }
    }
}