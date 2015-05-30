using UnityEngine;

namespace Assets.Scripts
{
    public class LookDirection : MonoBehaviour
    {

        private bool _lookingRight = true;
        void Start ()
        {

        }
	
        // Update is called once per frame
        void Update () {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && _lookingRight)
            {
                Flip();
            } 

            if (Input.GetKeyDown(KeyCode.RightArrow) && !_lookingRight){
                Flip();
            }
        }

        void Flip()
        {
            var vec = transform.localScale;
            vec.x = transform.localScale.x * -1;
            transform.localScale = vec;
            _lookingRight = !_lookingRight;
        }
    }
}
