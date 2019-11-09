using System;
using System.Collections;
using System.Collections.Generic;
using Fay;
using UnityEngine;
using UnityEngine.UI;

public class TentManager : MonoBehaviour
{
    [SerializeField] Image tent;
    [SerializeField] RectTransform corner;
    [SerializeField] CanvasElementMoverAnchored mover;
    
    float startWidth;
    float startHeight;

    bool isMovable;

    private Vector2 touchPosition;
    private bool mouseDown = false;

    public void Initialize()
    {
        var rect = tent.rectTransform.rect;

        startWidth = rect.width;
        startHeight = rect.height;

        isMovable = true;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mouseDown = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            mouseDown = false;
        }

        if (isMovable)
        {
            if (Input.touchCount > 0)
            {
                var touch = Input.GetTouch(0);
                touchPosition = touch.position;
                AdjustTent();

            }
            else if(mouseDown)
            {
                touchPosition = Input.mousePosition;
                AdjustTent();
            }
            else ResetTent();
        }
    }

    private void AdjustTent()
    {
        var position = corner.position;
        var offset = new Vector2(position.x, position.y) - touchPosition;

        tent.rectTransform.sizeDelta = offset;

        if (HitsTargetPanel(touchPosition))
        {
            isMovable = false;
            Stick();
        }
    }

    void ResetTent()
    {
        var rect = tent.rectTransform.rect;
        rect.width = startWidth;
        rect.height = startHeight;
    }

    void Stick()
    {
        mover.MoveUp(-100);
        StartCoroutine(WaitAndFinish(1.5f));
    }

    IEnumerator WaitAndFinish(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        MemoryManager.Instance.Next();
    }

    bool HitsTargetPanel(Vector2 position)
    {
        var rect = tent.rectTransform.rect;
        return rect.width >= 380 && rect.height <= 420 && rect.height >= 380 && rect.height <= 420;
    }
}