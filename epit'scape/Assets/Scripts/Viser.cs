using UnityEngine;
using System.Collections;

public class Viser : MonoBehaviour {
	public GameObject arme;
	public GameObject lieuDepart;
	public GameObject lieuArrivee;
	bool enVisee = true;
	float vitesseVisee = 0.65f;
	//float tps = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			
			if (Input.GetKey ("v") && enVisee) {
			   arme.transform.position = Vector3.Lerp(arme.transform.position, lieuArrivee.transform.position, vitesseVisee);

			}
			if (Input.GetKey("b")&& enVisee == false)
			{
				enVisee = !enVisee;
			    arme.transform.position = Vector3.Lerp (arme.transform.position, lieuDepart.transform.position, vitesseVisee);

					}
	
	}

}
