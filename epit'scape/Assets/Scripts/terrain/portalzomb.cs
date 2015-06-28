using UnityEngine;
using System.Collections;
using Assets.Scripts.questStuff;
using Assets.Scripts.display;
public class portalzomb : MonoBehaviour {
    public string destination;
    public string quest;
	// Use this for initialization
	void Awake () 
    {
        QuestAffichage.str = quest;
	}
    
    void OnTriggerEnter(Collider c)
    {
        if (Zombquest.victimes > 0)
        {
            QuestAffichage.str = "Restzomb";
        }
        else
            Application.LoadLevel(destination);
    }
	
	// Update is called once per frame
	void Update () {
        QuestAffichage.str = quest;
    }
}
