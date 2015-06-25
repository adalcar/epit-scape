using UnityEngine;
using System.Collections;
using Assets.Scripts.questStuff;
public class tuto : MonoBehaviour {
    bool movedone, attackable, attackdone, weaponshiftable, weaponshiftdone;
	// Use this for initialization
	void Start ()
    {
        movedone = Application.loadedLevelName != "level 0";
        attackdone = Penquest.questcompleted;
        weaponshiftdone = KeyboardQuest.questcompleted;
	}
	
	// Update is called once per frame
	void Update ()
    {
	     attackable = Penquest.questcompleted;
         weaponshiftable = KeyboardQuest.questcompleted || Bananalauncherquest.questcompleted;
    }
    void OnGUI()
    {
        if (!movedone)
            movetuto();
        if (!attackdone && attackable)
            attacktuto();
        if (weaponshiftable && !weaponshiftdone)
            shifttuto();
    }
    void movetuto()
    {

    }
    void attacktuto()
    {

    }
    void shifttuto()
    {

    }
}
