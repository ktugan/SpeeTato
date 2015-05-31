using UnityEngine;
using System.Collections;

public class MoveObstacle : MonoBehaviour {

    public Vector2 velocity = new Vector2(-4, 0);
    private Rigidbody2D rg;
    void Start ()
    {
        rg = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
	{
	    rg.velocity = velocity;
	}
}
