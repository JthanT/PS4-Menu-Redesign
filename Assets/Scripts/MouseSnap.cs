using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSnap : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Cursor.visible = (false);
        Cursor.lockState = CursorLockMode.Confined;
	}
	
	// Update is called once per frame
	void Update () {
        // For developer use to enable the cursor
        if(Input.GetKeyDown(KeyCode.Q)) {
            Cursor.visible = (true);
        }

        // For developer use to disable the cursor
        if (Input.GetKeyDown(KeyCode.W))
        {
            Cursor.visible = (false);
        }
	}
}
