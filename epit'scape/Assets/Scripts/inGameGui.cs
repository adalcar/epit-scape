using UnityEngine;
using System.Collections;

public class inGameGui : MonoBehaviour {
    public GUISkin skin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Info(string infostring)
    {
        GUI.Label(new Rect(Screen.width / 2 - 40, Screen.height - 50, 80, 20), infostring);
    }
}
