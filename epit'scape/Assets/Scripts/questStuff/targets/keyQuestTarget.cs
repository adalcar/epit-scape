using UnityEngine;
using System.Collections;
using Assets.Scripts.questStuff;
public class keyQuestTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            if (keyQuest.queststarted)
            {
                Destroy(gameObject);
                keyQuest.add();
                QuestAffichage.str = "";
            }

    }
	// Update is called once per frame
	void Update () {
        if (keyQuest.questcompleted)
            Destroy(gameObject);
	}
}
