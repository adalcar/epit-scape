using UnityEngine;
using System.Collections;

public class QuestManager : MonoBehaviour
{
    void Update()
    {
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            if (!GetComponent<Quest>().isStarted)
            {
                GetComponent<Quest>().isStarted = true;
                StartCoroutine(coll.GetComponentInChildren<inGameGui>().Info("tu vas en chier"));
            }

            if (GetComponent<Quest>().isFinished)
            {
                string name = this.name;
                switch (name)
                {
                    case "Porte":
                        Application.LoadLevel("Level 01");
                        break;
                    case "PO-1":
                        Application.LoadLevel("Level 01");
                        break;
                }


                /*if(this.name == "Porte")
                {
                    Application.LoadLevel("Level 01");
                }
                if(this.name == "P0-1")
                {
                    Application.LoadLevel("Level 02");
                }*/
            }
        }
    }
}
