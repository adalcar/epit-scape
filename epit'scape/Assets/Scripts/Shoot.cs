using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public Transform bullet;
	public GameObject posCanon;
    public bool monArme = true;
	public int munitions = 10;
	float cadence = 0.2f; 

	
	// Update is called once per frame
	void Update () {

			if (Input.GetKey ("f") && monArme && (munitions>0)) {
			    munitions--;
				Transform balle;
				balle = Instantiate (bullet, posCanon.transform.position, posCanon.transform.rotation) as Transform;
				balle.GetComponent<Rigidbody>().AddForce (posCanon.transform.forward * 1200);
				monArme = false;
				StartCoroutine (StartWait ());

			}
		if (Input.GetKey ("r")) {
			munitions = 10;
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

		GUI.Box(new Rect(0, 0, 90, 20), "Munitions: " + munitions);
	}




    



}
