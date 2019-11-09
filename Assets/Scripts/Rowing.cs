using UnityEngine;
using UnityEngine.UI;

namespace Fay.Camping
{
    public class Rowing : MonoBehaviour
    {
        [SerializeField] Image boat;
        [SerializeField] Sprite front;
        [SerializeField] Sprite back;
        [SerializeField] float cycleLength = 5;
        [SerializeField] int cycleCount = 5;
        [SerializeField] Button rowingButton;

        int currentCycle;

        public void Initialize()
        {
            ShowRowingButton();
        }
        
        public void RowOneCycle()
        {
            var offset = Vector3.right * cycleLength;
            
            boat.transform.position += offset;
            rowingButton.transform.position += offset;

            boat.sprite = currentCycle % 2 == 0 ? front : back;
            
            currentCycle++;

            if (cycleCount == currentCycle)
            {
                Finish();
            }
        }

        void ShowRowingButton()
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