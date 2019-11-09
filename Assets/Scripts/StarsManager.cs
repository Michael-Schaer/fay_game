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
            starImage.sprite = starImages[currentConnection];
            currentConnection++;
            
            if (currentConnection >= starImages.Count)
            {
                MemoryManager.Instance.Next();
            }
        }
    }
}