using Core.Events;
using UnityEngine;

namespace Fay
{
    public class ImageMemoryElement : BaseMemoryElement
    {
        Animator animator;

        void Awake()
        {
            animator = GetComponent<Animator>();
        }

        public override void Initialize()
        {
            ShowImage();
        }

        public void ShowImage()
        {
            animator.SetTrigger("Show");
        }

        public void HideImage()
        {
            animator.SetTrigger("Hide");
        }

        public void OnImageHidden()
        {
            MemoryManager.Instance.Next();
        }
    }
}