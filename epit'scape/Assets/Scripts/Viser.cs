using UnityEngine;
using System.Collections;

public class Viser : MonoBehaviour {
	public GameObject arme;
	public GameObject lieuDepart;
	public GameObject lieuArrivee;
	bool enVisee = false;
	float vitesseVisee = 0.1f;
	float tps = 0.1f;
	
	
	// Update is called once per frame
	void Update () {

		
		if (Input.GetKey ("v")) {
			enVisee = !enVisee;

		}
		
		if (enVisee) { 

			StartCoroutine (StartWait ());
		}
		
		if (enVisee == false) {
			
			StartCoroutine (StartWait2 ());
		}
	}


	IEnumerator StartWait()
	{   
		arme.transform.position = Vector3.Lerp (arme.transform.position, lieuArrivee.transform.position, vitesseVisee);
		yield return new WaitForSeconds(tps);}
	

	IEnumerator StartWait2()
	{   
        arme.transform.position = Vector3.Lerp (arme.transform.position, lieuDepart.transform.position, vitesseVisee);
		yield return new WaitForSeconds(tps);}
	
}
	

