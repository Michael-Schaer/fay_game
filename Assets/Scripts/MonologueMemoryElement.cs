using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Fay
{
    public class MonologueMemoryElement : BaseMemoryElement
    {
        [SerializeField] List<string> sequence;
        [SerializeField] TextMeshProUGUI textField;
    
        int index;
    
        public void Next()
        {
            if (index >= sequence.Count)
            {
                Finish();
                return;
            }

            textField.text = sequence[index++];
        }
    
        public override void Initialize()
        {
            // show bubble

            Next();
        }
    }
}