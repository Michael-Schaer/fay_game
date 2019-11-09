using System.Collections;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    [SerializeField] StartTitle title;
    [SerializeField] SceneBlender blender;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(15);
        title.Show();
        
        yield return new WaitForSeconds(5);
        blender.StartBlendOut();
    }
}