using UnityEngine;
using System.Collections;

public class inGameGui : MonoBehaviour {
    public GUISkin skin;
    bool infoLabel;
    public GameObject terrain;
    string infoLabelText;
    public GameObject enemy;
	// Use this for initialization
	void Start () {
        infoLabel = false;
        Screen.showCursor = false;
        Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
	}
    void OnGUI()
    {
        if (infoLabel)
        {
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 200, 20), infoLabelText);
            if (terrain.GetComponent<gametime>().gettimesince("labelon") >= 60)
                infoLabel = false;
        }
            
    }
    public void Info(string infostring)
    {
        Debug.Log("spot!");
        infoLabelText = infostring;
        infoLabel = true;
        terrain.GetComponent<gametime>().savetime("labelOn");
    }
}
