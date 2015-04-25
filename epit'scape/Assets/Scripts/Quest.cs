using UnityEngine;
using System.Collections;

public class Quest : MonoBehaviour 
{
    public bool isFinished;
    public bool isStarted;
    public int aim;


	// Use this for initialization
	void Start () 
    {
        aim = 3;
        isStarted = false;
        isFinished = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(isStarted == true &&  GameObject.FindWithTag("Player").GetComponent<PlayerStat>().current_score >= aim)
        {
            isFinished = true;
        }
	}
}
