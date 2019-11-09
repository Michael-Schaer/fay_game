using TMPro;
using UnityEngine;

public class StartTitle : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI title;
    
    bool show;
    
    public void Show()
    {
        show = true;
    }

    float t = 0;
    void Update()
    {
        if (show)
        {
            Color color = title.color;
            color.a = Mathf.Lerp(color.a, 1, t);
            title.color = color;
            t = Mathf.Clamp01(t + 0.05f);
        }
    }
}