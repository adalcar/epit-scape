using UnityEngine;
using System.Collections;

public class other_imputs : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Cancel"))
        {
            Application.LoadLevel("MainMenu");
            Screen.showCursor = true;
            Screen.lockCursor = false;
        }
        if (Input.GetButton("mousefree"))
        {
            Screen.showCursor = !Screen.showCursor;
            Screen.lockCursor = !Screen.lockCursor;
        }

	}
}
