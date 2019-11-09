using DigitalRubyShared;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    GestureRecognizer tapGesture;

    void Start()
    {
        CreateTapGesture();
    }

    void CreateTapGesture()
    {
        tapGesture = new TapGestureRecognizer();
        tapGesture.StateUpdated += OnTap;
        FingersScript.Instance.AddGesture(tapGesture);
    }

    void OnTap(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended)
        {
           Debug.Log(Camera.main.ScreenToViewportPoint(gesture.TouchPosition()));
            
           
        }
    }
}