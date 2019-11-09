using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Fay
{
    public class MonologueMemoryElement : BaseMemoryElement
    {
        [SerializeField] List<string> sequence;
        [SerializeField] TextMeshProUGUI textField;
        [SerializeField] Animator bubbleAnimator;
        
        int index;
    
        public void Next()
        {
            if (index >= sequence.Count)
            {
                Finish();
                return;
            }

            if(index > 0) bubbleAnimator.SetTrigger("Wiggle");
            StartCoroutine(WaitAndShowText(1));
        }
    
        public override void Initialize()
        {
            gameObject.SetActive(true);
            bubbleAnimator.SetTrigger("Show");
            
            Next();
        }

        IEnumerator WaitAndShowText(float seconds)
        {
            yield return new WaitForSeconds(seconds);
            textField.text = sequence[index++];
        }

        internal override void Finish()
        {
            // gameObject.SetActive(false);
            
            base.Finish();
        }
    }
}