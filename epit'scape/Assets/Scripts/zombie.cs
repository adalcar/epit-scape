using UnityEngine;
using System.Collections;

public class zombie : MonoBehaviour 
{
	public int life = 100;
    public Animator a;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (life <= 0) 
        {
            a.Play("dead");
            Destroy(gameObject);		
		};
	}
	
	void OnTriggerEnter(Collider c)
	{
		Debug.Log("contact");
		if (c.tag == "bullet")
		{
			life = life - 20;
		}
	}
}