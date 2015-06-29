using UnityEngine;
using System.Collections;
using Assets.Scripts.questStuff;
using Assets.Scripts.display;
public class portalzomb : MonoBehaviour {
    public string destination;
    public string quest;
    public string questdone = "clear1";
    bool tested, done;
    public GameObject spawn;
	// Use this for initialization
	void Start () 
    {
        QuestAffichage.str = quest;
	}
    
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
            if (!done)
            {
                tested = true;
            }
            else
                Application.LoadLevel(destination);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (quest != "")
        {
            done = (Zombquest.victimes == 0);

            if (!done)
                if (!tested)
                    QuestAffichage.str = quest;
                else
                    QuestAffichage.str = "Restzomb";
            else
                QuestAffichage.str = questdone;
        }
        if (Application.loadedLevelName == "under" && quest == "")
        {
            if (Bananalauncherquest.questcompleted)
                quest = "killallzomb6";
        }

    }
}
