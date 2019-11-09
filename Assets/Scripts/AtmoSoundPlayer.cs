using UnityEngine;

namespace Fay
{
    public class AtmoSoundPlayer : MonoBehaviour
    {
        void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}