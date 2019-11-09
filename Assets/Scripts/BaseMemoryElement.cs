using UnityEngine;

namespace Fay
{
    public abstract class BaseMemoryElement : MonoBehaviour
    {
        public abstract void Initialize();

        internal void Finish()
        {
            MemoryManager.Instance.Next();
        }
    }
}