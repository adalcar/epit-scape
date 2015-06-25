using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class movetuto : MonoBehaviour {
    public GameObject disp;
    new bool enabled = true;
	// Use this for initialization
	void Start ()
    {
        disp.SetActive(true);
        Text[] texts = disp.GetComponentsInChildren<Text>();
        texts[0].text = Biblio.Text("down");
        texts[1].text = Biblio.Text("up");
        texts[2].text = Biblio.Text("left");
        texts[3].text = Biblio.Text("right");
        texts[4].text = Biblio.Text("tutomove");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (enabled && (Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical")))
            StartCoroutine(fadeaway());
	}
    IEnumerator fadeaway()
    {
        enabled = false;
        yield return new WaitForSeconds(2);
        disp.SetActive(false);
    }
}
