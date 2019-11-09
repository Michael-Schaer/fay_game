using Core.Events;
using UnityEditor;
using UnityEngine;

namespace Core.GameEvents.Editor
{
    [CustomEditor(typeof(StringEvent))]
    public class StringEventEditor : BaseEventEditor<string>
    {
        protected override void ShowValueField()
        {
            value = GUILayout.TextField(value);
        }
    }
}