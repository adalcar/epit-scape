using UnityEngine;
using System.Collections;

public class gatee : MonoBehaviour {

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
