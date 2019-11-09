using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBlender : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private float durationSec = 2;
    [SerializeField] private string nextSceneName = "";
    private float alpha = 1;
    private bool blendOut = false;
    private float startTime;

    public void StartBlendOut()
    {
        startTime = Time.time;
        blendOut = true;
    }

    private void Update()
    {
        if(blendOut)
        {
            if (Time.time - startTime > durationSec)
            {
                blendOut = false;
                EndBlendOut();
            }

            alpha = 1-(Time.time - startTime) / durationSec;
            canvasGroup.alpha = alpha;
        }
    }

    private void EndBlendOut()
    {
        alpha = 0;
        canvasGroup.alpha = alpha;
        SceneManager.LoadScene(nextSceneName);
    }
}
