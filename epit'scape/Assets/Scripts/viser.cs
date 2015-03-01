using UnityEngine;
using System.Collections;

public class viser : MonoBehaviour {
	public GameObject positionDepart;
	public GameObject positionArrivee;
	bool enVise = false;
	float vitesseViser = 0.4F;
	public GameObject arme;



	// Update is called once per frame
	void Update () {
		if (Input.GetKey("v")) {
			enVise = !enVise;
		}
		if (enVise == true) {
			arme.transform.position = Vector3.Lerp (arme.transform.position, positionArrivee.transform.position, vitesseViser);
		}
		}

	}

