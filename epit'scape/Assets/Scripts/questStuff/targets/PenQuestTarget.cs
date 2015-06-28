﻿using UnityEngine;
using System.Collections;
using Assets.Scripts.questStuff;
using Assets.Scripts.display;
public class PenQuestTarget : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        
	}
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            Penquest.start();
            QuestAffichage.str = "goUp";
            Destroy(gameObject);
            Penquest.add();
            Debug.Log("Tancrede je vais te crever");
            c.GetComponentInChildren<WeaponShift>().enableweapon(1);
        }

    }
	// Update is called once per frame
	void Update () 
    {
        if (Penquest.questcompleted)
            Destroy(gameObject);
        else
            QuestAffichage.str = "findpen";
	}
}
