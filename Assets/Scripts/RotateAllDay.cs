using UnityEngine;

namespace Assets.Scripts
{
    public class RotateAllDay : MonoBehaviour
    {

        public float RotationsPerMinute = 30f;

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(0, 6f * RotationsPerMinute * Time.deltaTime, 0);
        }
    }
}
