using UnityEngine;
using System.Collections;
using Assets.Scripts.questStuff;

public class portal1 : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (!keyQuest.queststarted)
            {
                keyQuest.start();
                QuestAffichage.str = "recupCles";
            }

            if (keyQuest.questcompleted)
            {
                Application.LoadLevel("Level 1");
            }
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
