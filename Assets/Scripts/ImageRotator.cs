using System.Collections;
using UnityEngine;

namespace Fay
{
    public class ImageRotator : MonoBehaviour
    {
        [SerializeField] float rotationSpeed;
        [SerializeField] float fallingSpeed;
        [SerializeField] float delay;
        [SerializeField] bool randomlySetValues;

        bool fall;
        
        IEnumerator Start()
        {
            if (randomlySetValues)
            {
                rotationSpeed = Random.Range(-4f, 4f);
                fallingSpeed = Random.Range(3f, 5f);
                delay = Random.Range(6f, 10f);
            }
            
            yield return new WaitForSeconds(delay);
            fall = true;

            yield return new WaitForSeconds(25);
            
        }

        void Update()
        {
            if (fall)
            {
                transform.Rotate(Time.deltaTime * rotationSpeed * 100 * Vector3.forward);
            
                var position = transform.position;
                position.y -= Time.deltaTime * fallingSpeed * 100;
                transform.position = position;
            }
        }
    }
}