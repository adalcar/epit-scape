using UnityEngine;
using System.Collections;

public class QuestManager : MonoBehaviour 
{
	void Update () 
    {
	}

    void OnTriggerEnter(Collider coll)
    {
        if( coll.tag == "Player" /*&& Input.GetButtonDown("x")*/)
        {
            if(!GetComponent<Quest>().isStarted)
            {
                GetComponent<Quest>().isStarted = true;
                StartCoroutine(coll.GetComponentInChildren<inGameGui>().Info("tu vas en chier"));
            }

            if(GetComponent<Quest>().isFinished)
            {
                if(this.name == "Porte")
                {
                    Application.LoadLevel("Level 01");
                }
            }
        }
    }
}
