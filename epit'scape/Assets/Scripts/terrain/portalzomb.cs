using UnityEngine;
using System.Collections;
using Assets.Scripts.questStuff;
using Assets.Scripts.display;
public class NewBehaviourScript : MonoBehaviour {
    public string destination;
	// Use this for initialization
	void Start () 
    {
	    
	}
    void OnTriggerEnter(Collider c)
    {
        if (Zombquest.vikos.Count > 0)
        {
            display.infodisplay(Zombquest.vikos.Count + " enemies remaining, nowhere to run!");
        }
        else
            Application.LoadLevel(destination);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
