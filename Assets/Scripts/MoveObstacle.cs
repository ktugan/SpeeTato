using UnityEngine;

namespace Assets.Scripts
{
    public class MoveObstacle : MonoBehaviour {

        public Vector2 Velocity = new Vector2(-4, 0);
        private Rigidbody2D rg;
        void Start ()
        {
            rg = GetComponent<Rigidbody2D>();
            Velocity.x = Random.Range(-8, -4);
        }
	
        // Update is called once per frame
        void Update ()
        {
            rg.velocity = Velocity;
        }
    }
}
