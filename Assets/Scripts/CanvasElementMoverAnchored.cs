using System.Collections;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class CanvasElementMoverAnchored : MonoBehaviour
{
    [SerializeField] float defaultSpeed = 1;
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    public void MoveToPosition(Vector2 target)
    {
        MoveToPosition(target, defaultSpeed);
    }

    void MoveToPosition(Vector2 target, float speed)
    {
        StartCoroutine(Move(rectTransform.anchoredPosition, target, speed));
    }

    IEnumerator Move(Vector2 origin, Vector2 target, float speed)
    {
        float t = 0;

        while (t < 1)
        {
            Vector2 position = Vector2.Lerp(origin, target, t);
            rectTransform.anchoredPosition = position;

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
        var target = rectTransform.anchoredPosition;
        target.y += pixels;
        MoveToPosition(target, speed);
    }

    public void MoveRight(float pixels)
    {
        MoveRight(pixels, defaultSpeed);
    }

    void MoveRight(float pixels, float speed)
    {
        var target = rectTransform.anchoredPosition;
        target.x += pixels;
        MoveToPosition(target, speed);
    }

    public void MoveUpRight(Vector2 pixels)
    {
        MoveUpRight(pixels.x, pixels.y, defaultSpeed);
    }

    void MoveUpRight(float pixelsRight, float pixelsUp, float speed)
    {
        var target = rectTransform.anchoredPosition;
        target.x += pixelsRight;
        target.y += pixelsUp;
        MoveToPosition(target, speed);
    }
}