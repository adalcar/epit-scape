using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestAffichage : MonoBehaviour {
    Text t;
    public static string str;

	// Use this for initialization
	void Start () {
        t = GetComponent<Text>();
        str = "";
	}
	
	// Update is called once per frame
	void Update () {
        if (str == "")
            t.enabled = false;
        else
        {
            t.enabled = true;
            t.text = Biblio.Text(str);
        }
	}
}
