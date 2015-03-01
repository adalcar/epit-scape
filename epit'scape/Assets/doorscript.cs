using UnityEngine;
using System.Collections;

public class doorscript : MonoBehaviour {
    public bool closed, locked;
    Animation anim;
	// Use this for initialization
	void Start () 
    {
        anim = transform.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    public void interact()
    {
        
        if (!locked)
        {
            if (closed)
            {
                
                anim.Play("DoorOpen");
                closed = false;
            }
            else
            {
                anim.Rewind("DoorOpen");
                closed = true;
            }
        }
    }
}
