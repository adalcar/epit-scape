using UnityEngine;
using System.Collections;

public class gate : MonoBehaviour {

    void OnTriggerEnter(Collider coll)
    {
        if(coll.tag == "Player")
        {
            
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
