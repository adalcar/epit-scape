using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Transform bullet;
	public GameObject posCanon;
    public bool monArme = true;

	float cadence = 0.2f; 
	
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey("f") && monArme ) {

			Transform balle;
			balle = Instantiate(bullet,posCanon.transform.position,posCanon.transform.rotation) as Transform;
			balle.rigidbody.AddForce(transform.forward * 1200);
			monArme = false;
			StartCoroutine(StartWait());

		}

	
	}
	IEnumerator StartWait()
	{   
		yield return new WaitForSeconds(cadence);
		monArme = true;

	}



}
