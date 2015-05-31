using UnityEngine;

namespace Assets.Scripts
{
    class Rotate : MonoBehaviour
    {

        public float RotationsPerMinute = 30f;

        void Update()
        {
            transform.Rotate(0, 0, 6f * RotationsPerMinute * Time.deltaTime);
        }
    }
}
