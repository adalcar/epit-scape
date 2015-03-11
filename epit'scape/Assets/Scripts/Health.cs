using UnityEngine;
using System.Collections;


public class Health : MonoBehaviour {
    public int life = 100;
    public Animator anim;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (life <= 0)
            StartCoroutine(death());

	}
    IEnumerator death()
    {
        anim.Play("dead");
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
