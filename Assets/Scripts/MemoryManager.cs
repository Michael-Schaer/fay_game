using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Fay
{
    public class MemoryManager : MonoBehaviour
    {
        [SerializeField] List<UnityEvent> sequence;
        [SerializeField] string nextSceneName;

        int index;
    
        public static MemoryManager Instance { get; private set; }

        void Awake()
        {
            if (Instance)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }

        void Start()
        {
            Next();
        }

        public void Next()
        {
            if (index >= sequence.Count)
            {
                NextScene();
                return;
            }

            sequence[index++].Invoke();
        }

        void NextScene()
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}