﻿using UnityEngine;
using System.Collections;

public class recharge : MonoBehaviour {
    int munition = 10;

    void OnTriggerEnter(Collider coll)
    {
        if(coll.tag == "bullet")
        {
            //coll.GetComponent<Shoot>().munitions = 10;
            Destroy(this.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
