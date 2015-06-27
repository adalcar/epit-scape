using UnityEngine;
using System.Collections;
using Assets.Scripts.display;
public class penquestportal : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Debug.Log("col");
            if (Penquest.questcompleted)
            {
                Debug.Log("sucess");
                enter();
            }
            else display.infodisplay("closedDoor");
        }
    }
	// Update is called once per frame
	void Update () {
	    
	}
    void enter()
    {
        Application.LoadLevel("Level 2");
    }
}
