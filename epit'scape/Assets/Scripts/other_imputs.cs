using UnityEngine;
using System.Collections;
using Assets.Scripts.questStuff;
public class other_imputs : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("mousefree"))
        {
            Cursor.visible = !Cursor.visible;
            if (Cursor.lockState == CursorLockMode.Locked)
                Cursor.lockState = CursorLockMode.None;
            else
                Cursor.lockState = CursorLockMode.Locked;
        }
        if(Input.GetButtonDown("cheat"))
        {
            Penquest.questcompleted = true;
            keyQuest.questcompleted = true;
            Bananalauncherquest.questcompleted = true;
            GetComponentInChildren<WeaponShift>().cheat();
        }

	}
}
