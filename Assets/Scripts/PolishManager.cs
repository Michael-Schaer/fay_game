using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Fay.Camping
{
    public class PolishManager : MonoBehaviour
    {
        [SerializeField] Image ring1, ring2, starts, tool;
        [SerializeField] Button button1, button2, button3;

        private int imageCounter = 0;

        int currentCycle;

        public void Initialize()
        {
            ShowButton();
        }

        public void SwitchImage()
        {
           /* if (imageCounter == 0)
            {
                laser.enabled = true;
            }
            else if (imageCounter == 1)
            {
                laser.enabled = false;
                stone_1.enabled = false;
                stone_2.enabled = true;
                button1.gameObject.SetActive(false);
                button2.gameObject.SetActive(true);
            }
            else if (imageCounter == 2)
            {
                position_neutral.enabled = false;
                position_cut.enabled = true;
                button2.gameObject.SetActive(false);
                button3.gameObject.SetActive(true);
            }
            else if (imageCounter == 3)
            {
                position_cut.enabled = false;
                position_hammeron.enabled = true;
                button3.gameObject.SetActive(false);
                button1.gameObject.SetActive(true);
            }
            else
            {
                Finish();
            }*/
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
