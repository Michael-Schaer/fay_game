using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Fay
{
    [RequireComponent(typeof(Image))]
    public class ImageMover : MonoBehaviour
    {
        public Vector2 startPosition, endPosition;

        private GameObject imageObject;

        void Start()
        {
            imageObject = gameObject.GetComponent<Image>().gameObject;
            //imageObject.transform.
        }

        void Update()
        {

        }
    }

}
