using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour
{

    public float Speed = 4f;
    public Vector3 JumpHeight;

    public Rigidbody Rb;

    private Vector3 _initialLookdirection;

	// Use this for initialization
	void Start ()
	{
	    Rb = GetComponent<Rigidbody>();
	    _initialLookdirection = transform.localScale;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var dir = Vector3.right*Input.GetAxis("Horizontal")*Speed*Time.deltaTime;
        transform.Translate(dir);

        if (Input.GetButtonDown("Jump"))
	    {
	        Rb.AddForce(JumpHeight);
	    }
	}
}
