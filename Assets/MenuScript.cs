using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))//KeyCode.escape
        {
            Application.LoadLevel("SpeedTato");
        }
	}

    public void OnClickPlay()
    {
        Application.LoadLevel("SpeedTato");
    }

    public void OnClickExit()
    {
        //Application.LoadLevel("Quit");
        Application.Quit();
    }

    public void OnClickSpace()
    {

        if (Input.GetKeyDown("space"))//KeyCode.escape
        {
            Application.LoadLevel("SpeedTato");
        }
    }
 
}
