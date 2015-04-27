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
        if(this.name == "Porte") // quete 1
        {
            aim = 1;
        }
        isStarted = false;
        isFinished = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        isFinished = isStarted && GameObject.FindWithTag("Player").GetComponent<PlayerStat>().current_score >= aim;
	}
}
