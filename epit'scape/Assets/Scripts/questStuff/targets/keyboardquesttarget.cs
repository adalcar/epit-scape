using UnityEngine;
using System.Collections;

public class keyboardquesttarget : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        QuestAffichage.str = "findkeyboard";
        KeyboardQuest.queststarted = true;
	}
	void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {

            QuestAffichage.str =  "gobocal1";
            KeyboardQuest.questcompleted = true;
            col.GetComponentInChildren<WeaponShift>().enableweapon(2);
            Destroy(gameObject);
        }
        

    }
	// Update is called once per frame
	void Update () {
	
	}
}
