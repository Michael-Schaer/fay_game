using Fay;
using UnityEngine;

public class ImageMemoryElement : BaseMemoryElement
{
    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public override void Initialize()
    {
        animator.SetTrigger("SHOW_NEXT");
    }
}