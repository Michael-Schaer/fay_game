using System.Collections;
using UnityEngine;

public class OutroManager : MonoBehaviour
{
    [SerializeField] StartTitle title;
    
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        title.Show();
    }
}