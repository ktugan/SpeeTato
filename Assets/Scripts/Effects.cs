using UnityEngine;

namespace Assets.Scripts
{
    public class Effects : MonoBehaviour
    {

        public float RepeatTime = 5f;
        public float DeltaMultiplier = 0.2f;
        void Start()
        {
            InvokeRepeating("SpeedUp", RepeatTime, RepeatTime);
        }

        void SpeedUp()
        {
            MoveObstacle.Multiplier += DeltaMultiplier;
        }
    }
}
