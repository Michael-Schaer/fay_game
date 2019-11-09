using DigitalRubyShared;
using UnityEngine;

namespace Fay
{
    public static class Extensions
    {
        public static Vector2 TouchPosition(this GestureRecognizer gesture)
        {
            return new Vector2(gesture.FocusX, gesture.FocusY);
        }
    }
}