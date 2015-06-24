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
        armes.Add(new dummyWeapon());
        if (Penquest.questcompleted)
            armes.Add(weapons[0].GetComponent<weaponscriptPere>());
        if (KeyboardQuest.questcompleted)
            armes.Add(weapons[1].GetComponent<weaponscriptPere>());

        if (Bananalauncherquest.questcompleted)
            armes.Add(weapons[2].GetComponent<weaponscriptPere>());
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

    }
    void switchup()
    {

        if (activeweapon != 0)
            weapons[activeweapon - 1].SetActive(false);
        if (activeweapon == armes.Count)
            activeweapon = 0;
        else
        {
            activeweapon++;
            weapons[activeweapon - 1].SetActive(true);
        }
        
    }
    void switchdown()
    {
        if (activeweapon == 0)
            activeweapon = armes.Count;
        else
        {
            weapons[activeweapon - 1].SetActive(false);
            activeweapon--;
        }
        if (activeweapon != 0)
            weapons[activeweapon - 1].SetActive(true);
    }
    public void cheat()
    {
        int k = armes.Count;
        while (k < 5)
            armes.Add(weapons[k++].GetComponent<weaponscriptPere>());

    }
}
