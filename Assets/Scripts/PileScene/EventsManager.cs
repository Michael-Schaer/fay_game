using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Fay
{
    public class EventsManager : MonoBehaviour
    {
        [SerializeField] List<UnityEvent> sequence;
        [SerializeField] private float delaySec = 2;

        int index;
        private float timer = 0;

        public static EventsManager Instance { get; private set; }

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
            timer = Time.time + delaySec;
        }

        private void Update()
        {
            if(Time.time > timer)
            {
                timer = Time.time + delaySec;
                Next();
            }
        }

        public void Next()
        {
            if (index >= sequence.Count)
            {
                return;
            }

            sequence[index++].Invoke();
        }
    }
}