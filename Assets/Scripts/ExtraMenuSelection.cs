using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtraMenuSelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Loads settings menu
    public void SettingsMenu() 
    {
        SceneManager.LoadScene("Settings");
    }

    // Loads the top notification/profile menu
    public void ProfileMenu() 
    {
        SceneManager.LoadScene("ProfileMenu");
    }

    // Loads the game library
    public void GameLibrary()
    {
        SceneManager.LoadScene("GameLibrary");
    }
}
