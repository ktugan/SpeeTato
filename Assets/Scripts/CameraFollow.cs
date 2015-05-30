using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    public GameObject Camera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var vec = new Vector3(transform.position.x, transform.position.y, Camera.transform.position.z);
	    Camera.transform.position = vec;
	}
}
