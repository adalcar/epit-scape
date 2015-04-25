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
            if(GetComponent<Quest>().isStarted == false)
            {
                GetComponent<Quest>().isStarted = true;
            }

            if(GetComponent<Quest>().isFinished == true)
            {
                Application.LoadLevel("Level 0");
            }
        }
    }
}
