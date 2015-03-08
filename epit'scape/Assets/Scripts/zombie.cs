using UnityEngine;
using System.Collections;

public class zombie : MonoBehaviour {
	public GameObject zomb;
	private int life = 100;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (life <= 0) {
			DestroyObject(this.gameObject);
		};
	}
	
	/*void collisionObj(Collision coll)
	{
		if(coll.gameObject.tag == "bullet")
		{
			
			this.life -= 20;
		}
	}*/
}