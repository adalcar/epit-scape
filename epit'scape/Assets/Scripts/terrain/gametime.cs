using UnityEngine;
using System.Collections.Generic;

public class gametime : MonoBehaviour {
    int time;
    private Dictionary<string,int> times;
	// Use this for initialization
	void Start () {
        time = 0;
        times = new Dictionary<string, int> { };
	}
	
	// Update is called once per frame
	void Update () {
        time++;
	}
    public void savetime(string label)
    {
        if (times.ContainsKey(label))
        {
            times.Remove(label);
            times.Add(label, time);
        }
            
    }
    public int gettimesince(string label)
    {
        int savedtime;
        if (times.TryGetValue(label, out savedtime))
            return time - savedtime;
        else 
            return 0;
    }
}

