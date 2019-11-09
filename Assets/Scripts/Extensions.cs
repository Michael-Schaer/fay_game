using System.Collections;
using System.Collections.Generic;
using DigitalRubyShared;
using UnityEngine;

public static class Extensions
{
    public static Vector2 TouchPosition(this GestureRecognizer gesture)
    {
        return new Vector2(gesture.FocusX, gesture.FocusY);
    }
}