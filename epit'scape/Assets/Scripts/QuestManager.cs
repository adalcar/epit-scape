using UnityEngine;
using System.Collections;

public class QuestManager : MonoBehaviour
{
    public int current_score;
    void Start()
    {
        current_score = 0;
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "begin")
        {
            if (!GetComponent<Quest>().isStarted)
            {
                GetComponent<Quest>().isStarted = true;
                //StartCoroutine(coll.GetComponentInChildren<inGameGui>().Info("tu vas en chier"));
            }
        }

        if(coll.tag == "aim" && GetComponent<Quest>().isStarted)
        {
            this.current_score++;
            Destroy(coll.gameObject);
        }

        if (coll.tag == "end" && GetComponent<Quest>().isFinished)
        {
            string name = coll.name;
            switch (name)
            {
                case "Porte":
                    Application.LoadLevel("Level 1");
                    break;
                case "portal":
                    Application.LoadLevel("Level 01");
                    break;
            }
        }
    }
}
