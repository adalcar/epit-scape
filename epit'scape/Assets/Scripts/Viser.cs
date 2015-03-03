using UnityEngine;
using System.Collections;

public class Viser : MonoBehaviour {
	public GameObject arme;
	public GameObject lieuDepart;
	public GameObject lieuArrivee;
	bool enVisee = true;
	float vitesseVisee = 0.65f;
	float tps = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			
		if (Input.GetKey ("v")) {
			if (enVisee) {
				arme.transform.position = Vector3.Lerp (arme.transform.position, lieuArrivee.transform.position, vitesseVisee);
				enVisee = !enVisee;
				StartCoroutine (StartWait());
			} else {
				enVisee = !enVisee;
				arme.transform.position = Vector3.Lerp (arme.transform.position, lieuDepart.transform.position, vitesseVisee);
				StartCoroutine (StartWait());
			}
	
		}
	}
		IEnumerator StartWait()
		{   
			yield return new WaitForSeconds(tps);
			
		}

	}


