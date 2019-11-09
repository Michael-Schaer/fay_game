using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Fay.Camping
{
    public class PolishManager : MonoBehaviour
    {
        [SerializeField] Image ring1, ring2, stars;
        [SerializeField] Button button1, button2, button3;

        private int imageCounter = 0;

        int currentCycle;

        public void Initialize()
        {
            ShowButton();
        }

        public void SwitchImage()
        {
            if (imageCounter == 0)
            {
                ring1.enabled = false;
                ring2.enabled = true;
                button1.gameObject.SetActive(false);
                button2.enabled = true;
            }
            else if (imageCounter == 1)
            {
                stars.enabled = true;
                button2.gameObject.SetActive(false);
                button3.gameObject.SetActive(true);
            }
            else
            {
                Finish();
            }
            imageCounter++;

        }

        void ShowButton()
        {
            button1.gameObject.SetActive(true);
        }

        void Finish()
        {
            button1.gameObject.SetActive(false);
            MemoryManager.Instance.Next();
        }
    }
}
