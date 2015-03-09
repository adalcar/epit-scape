using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour { 
	private int degats = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Zomb")
		{
			Destroy(this.gameObject);
		}
	}
}
