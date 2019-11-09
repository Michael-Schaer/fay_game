using UnityEngine;
using UnityEngine.UI;

namespace Fay.Camping
{
    public class RowingManager : MonoBehaviour
    {
        [SerializeField] Image boat;
        [SerializeField] Sprite move;
        [SerializeField] Sprite wait;
        [SerializeField] float cycleLength = 5;
        [SerializeField] int cycleCount = 5;
        [SerializeField] Button rowingButton;
        [SerializeField] AudioClip waterSplash;

        int currentCycle;

        public void Initialize()
        {
            ShowRowingButton();
        }
        
        public void RowOneCycle()
        {
            var offset = Vector3.right * cycleLength;

            if (currentCycle % 2 == 0)
            {
                var audioGO = new GameObject();
                var audioSrc = audioGO.AddComponent<AudioSource>();
                audioSrc.clip = waterSplash;
                audioSrc.Play();
                Destroy(audioGO, 3);
                
                boat.transform.position += offset;
                rowingButton.transform.position += offset;
                boat.sprite = move;
            }
            else
            {
                boat.sprite = wait;
            }
            
            
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