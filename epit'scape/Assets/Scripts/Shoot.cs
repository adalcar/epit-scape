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

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Zomb")
		{
			Destroy(this.gameObject);
		}
	}

	IEnumerator StartWait()
	{   
		yield return new WaitForSeconds(cadence);
		monArme = true;
		
		
	}

	void OnGUI () {

		GUI.Box(new Rect(0, 0, 90, 20), "Munitions: " + minutions);
	}




    



}
