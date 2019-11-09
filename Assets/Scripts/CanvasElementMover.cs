using System.Collections;
using UnityEngine;

public class CanvasElementMover : MonoBehaviour
{
    [SerializeField] float defaultSpeed = 1;

    public void MoveToPosition(Vector2 target)
    {
        MoveToPosition(target, defaultSpeed);
    }

    void MoveToPosition(Vector2 target, float speed)
    {
        StartCoroutine(Move(transform.position, target, speed));
    }

    IEnumerator Move(Vector2 origin, Vector2 target, float speed)
    {
        float t = 0;

        while (t <= 1)
        {
            Vector2 position = Vector2.Lerp(origin, target, t);
            transform.position = position;
            
            t = Mathf.Clamp01(t + Time.deltaTime * speed);
            yield return null;
        }
    }

    public void MoveUp(float pixels)
    {
        MoveUp(pixels, defaultSpeed);
    }

    void MoveUp(float pixels, float speed)
    {
        var target = transform.position;
        target.y += pixels;
        MoveToPosition(target, speed);
    }

    public void MoveRight(float pixels)
    {
        MoveRight(pixels, defaultSpeed);
    }

    void MoveRight(float pixels, float speed)
    {
        var target = transform.position;
        target.x += pixels;
        MoveToPosition(target, speed);
    }

    public void MoveUpRight(Vector2 pixels)
    {
        MoveUpRight(pixels.x, pixels.y, defaultSpeed);
    }

    void MoveUpRight(float pixelsRight, float pixelsUp, float speed)
    {
        var target = transform.position;
        target.x += pixelsRight;
        target.y += pixelsUp;
        MoveToPosition(target, speed);
    }
}