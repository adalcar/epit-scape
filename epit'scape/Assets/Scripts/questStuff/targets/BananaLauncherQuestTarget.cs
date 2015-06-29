using UnityEngine;
using System.Collections;

public class BananaLauncherQuestTarget : MonoBehaviour
{
    public GameObject[] spawns;
    // Use this for initialization
    void Start()
    {
        QuestAffichage.str = "findBL";
        KeyboardQuest.queststarted = true;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            QuestAffichage.str = "";
            Bananalauncherquest.questcompleted = true;
            col.GetComponentInChildren<WeaponShift>().enableweapon(3);
            foreach (GameObject g in spawns)
                g.SetActive(true);

            Destroy(gameObject);
        }


    }
    // Update is called once per frame
    void Update()
    {


    }
}
