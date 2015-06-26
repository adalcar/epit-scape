using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class weapontuto : MonoBehaviour {
    bool activated, done1, done2;
    Text t;
	// Use this for initialization
	void Start () {
        t = GetComponent<Text>();
        activated = true;
        done2 = false;
        done1 = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Penquest.queststarted && activated)
        {
            done1 = true;
            t.enabled = true;
            t.text = Biblio.Text("tutoswitch");
        }
        if (done1 && Input.GetAxis("Mouse ScrollWheel") != 0)
            StartCoroutine(fade1());
        if (done2 && Input.GetMouseButtonDown(0))
            StartCoroutine(fade2());

        
	}
    IEnumerator fade1()
    {
        done1 = false;
        activated = false;
        yield return new WaitForSeconds(2);
        t.text = Biblio.Text("tutoshoot");
        done2 = true;
    }
    IEnumerator fade2()
    {
        done2 = false;
        yield return new WaitForSeconds(2);
        t.enabled = false;
    }
}
