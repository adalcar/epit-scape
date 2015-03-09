using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public Transform bullet;
	public GameObject posCanon;
    public bool monArme = true;
	public int minutions = 10;
	float cadence = 0.2f; 

	
	// Update is called once per frame
	void Update () {

			if (Input.GetKey ("f") && monArme && (minutions>0)) {
			    minutions--;
				Transform balle;
				balle = Instantiate (bullet, posCanon.transform.position, posCanon.transform.rotation) as Transform;
				balle.rigidbody.AddForce (posCanon.transform.forward * 1200);
				monArme = false;
				StartCoroutine (StartWait ());

			}
		if (Input.GetKey ("r")) {
			minutions = 10;
		}


	}




    IEnumerator StartWait()
	{   
		yield return new WaitForSeconds(cadence);
		monArme = true;


	}



}
