using UnityEngine;
using System.Collections;
using Assets.Scripts.Weapon_stuff;
public class recharge : MonoBehaviour {
    public int munition = 10;

    void OnTriggerEnter(Collider coll)
    {
        if(coll.tag == "Player")
        {
            if (coll.GetComponentInChildren<weaponscriptPere>().reload())
                Destroy(this.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
