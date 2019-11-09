using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Fay.Camping
{
    public class RingManager : MonoBehaviour
    {
        [SerializeField] Image first_1, first_2, second_1, second_2;
        [SerializeField] Button rowingButton;

        private int imageCounter = 0;

        int currentCycle;

        public void Initialize()
        {
            ShowButton();
        }

        public void SwitchImage()
        {
            if(imageCounter == 0)
            {
                first_1.enabled = false;
                first_2.enabled = false;
                second_1.enabled = true;
                second_2.enabled = true;
                imageCounter++;
            }
            else
            {
                Finish();
            }
            
        }

        void ShowButton()
        {
            rowingButton.gameObject.SetActive(true);
        }

        void Finish()
        {
            rowingButton.gameObject.SetActive(false);
            MemoryManager.Instance.Next();
        }
    }
}
