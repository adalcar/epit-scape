using UnityEngine;
using System.Collections.Generic;
using Assets.Scripts.questStuff;
using Assets.Scripts.Weapon_stuff;

public class WeaponShift : MonoBehaviour {
    int activeweapon;
    public GameObject[] weapons;
    private delegate void attack();
    public List<weaponscriptPere> armes;
	// Use this for initialization
	void Awake ()
    {
        activeweapon = 0;
        foreach (GameObject g in weapons)
        {
            g.SetActive(false);
        }
        armes.Add(weapons[0].GetComponent<weaponscriptPere>());
        if (Penquest.questcompleted)
            armes.Add(weapons[1].GetComponent<weaponscriptPere>());
        if (KeyboardQuest.questcompleted)
            armes.Add(weapons[2].GetComponent<weaponscriptPere>());

        if (Bananalauncherquest.questcompleted)
            armes.Add(weapons[3].GetComponent<weaponscriptPere>());
	}
	
	// Update is called once per frame
	void Update ()
    {
        #region switch
        float f = Input.GetAxis("Mouse ScrollWheel");
        if (armes.Count != 1)
            if (f != 0)
                if (f > 0)
                    switchup();
                else
                    switchdown();
        #endregion
        #region shoot
        if (Input.GetMouseButtonDown(0) && Time.timeScale != 0)
        {
            armes[activeweapon].shoot();
        }
        #endregion


    }
    void switchup()
    {

        weapons[activeweapon].SetActive(false);
        if (activeweapon == armes.Count - 1)
            activeweapon = 0;
        else
        {
            activeweapon++;
        }
        weapons[activeweapon].SetActive(true);
    }
    void switchdown()
    {
        weapons[activeweapon].SetActive(false);
        if (activeweapon == 0)
            activeweapon = armes.Count - 1;
        else
            activeweapon--;
        
        weapons[activeweapon].SetActive(true);
    }
    public void cheat()
    {
        int k = armes.Count;
        while (k < 4)
            armes.Add(weapons[k++].GetComponent<weaponscriptPere>());

    }
}
