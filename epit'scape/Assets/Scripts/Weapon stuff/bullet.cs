using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour { 
	public int degats = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
    void OnTriggerEnter(Collider coll)
    {
        if(coll.tag == "Enemy" )
        {
            Debug.Log("hit!");
            coll.GetComponent<EnemyHealth>().currentLife -= degats;
        }
        Destroy(this.gameObject);
    }


}
