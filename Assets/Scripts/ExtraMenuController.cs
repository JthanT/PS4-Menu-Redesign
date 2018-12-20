using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtraMenuController: MonoBehaviour {
   
	// Use this for initialization
	void Start () {
        Cursor.visible = (false);
        Cursor.lockState = CursorLockMode.Confined;
	}
	
	// Update is called once per frame
	void Update () {
        // Way of going back to main menu
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SceneManager.LoadScene("PlayStation4V2");
        }

        // For developer use to enable the cursor
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Cursor.visible = (true);
        }

        // For developer use to disable the cursor
        if (Input.GetKeyDown(KeyCode.W))
        {
            Cursor.visible = (false);
        }
	}
}
