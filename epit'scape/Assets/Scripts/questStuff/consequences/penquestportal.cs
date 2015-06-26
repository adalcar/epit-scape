using UnityEngine;
using System.Collections;
using Assets.Scripts.display;
public class penquestportal : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            if (Penquest.questcompleted)
                enter();
            else display.infodisplay("closedDoor");
                

        }
    }
	// Update is called once per frame
	void Update () {
	    
	}
    void enter()
    {
        Application.LoadLevel("Level 01");
    }
}
