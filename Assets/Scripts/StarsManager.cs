using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Fay.Camping
{
    public class StarsManager : MonoBehaviour
    {
        [SerializeField] Image starImage;
        [SerializeField] Image peopleImage;
        [SerializeField] List<Sprite> starImages;
        [SerializeField] Sprite pointingPeople;
        [SerializeField] AudioClip starBling;
        
        int currentConnection;
        
        public void Initialize()
        {
            
        }

        int lastButtonHit = -1;
        
        public void HitButton(int i)
        {
            if (lastButtonHit == currentConnection && lastButtonHit == i - 1)
            {
                if (i == 2) peopleImage.sprite = pointingPeople;
                
                AddOneConnection();
            }

            lastButtonHit = i;
        }

        void AddOneConnection()
        {
            var audioGO = new GameObject();
            var audioSrc = audioGO.AddComponent<AudioSource>();
            audioSrc.clip = starBling;
            audioSrc.Play();
            Destroy(audioGO, 3);
            
            starImage.sprite = starImages[currentConnection];
            currentConnection++;
            
            if (currentConnection >= starImages.Count)
            {
                MemoryManager.Instance.Next();
            }
        }
    }
}