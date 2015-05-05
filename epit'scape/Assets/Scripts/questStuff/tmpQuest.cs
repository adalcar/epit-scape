using UnityEngine;
using System.Collections;

public class tmpQuest : MonoBehaviour 
{
    public bool isFinished;
    public bool isStarted;
    public int aim;

	// Use this for initialization
	void Start () 
    {
        aim = 1;
        //if(this.name == "Porte") // quete 1
        //{
        //    aim = 1;
        //}
        //if(this.name == "P0-1")
        //{
        //    aim = 2;
        //}
        isStarted = false;
        isFinished = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        isFinished = GetComponent<QuestManager>().current_score == aim;
	}
}
