using UnityEngine;
using System.Collections;

public class PlayerStat : MonoBehaviour 
{
    public int current_score;
    public GameObject pnj;
	
    
    void Start () 
    {
        current_score = 0;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(pnj.GetComponent<Quest>().aim <= current_score)
        {
            current_score = pnj.GetComponent<Quest>().aim;
        }
	}
}
