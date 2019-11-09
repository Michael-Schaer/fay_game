using UnityEngine;

namespace Fay
{
    public abstract class BaseMemoryElement : MonoBehaviour
    {
        public abstract void Initialize();

        internal virtual void Finish()
        {
            MemoryManager.Instance.Next();
        }
    }
}