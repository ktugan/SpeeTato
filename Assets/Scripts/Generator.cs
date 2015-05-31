using UnityEngine;

namespace Assets.Scripts
{
    public class Generator : MonoBehaviour
    {

        public GameObject Obstacle;
        public float RepeatTime = 5.5f;
        private static int score = 0;

        void Start () {
            InvokeRepeating("CreateObstacle", 1f, RepeatTime);
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUILayout.Label(" Score: " + score.ToString());
        }

        // Update is called once per frame
        void CreateObstacle() {
            Instantiate(Obstacle);
            score++;
        }
    }
}
