using UnityEngine;
using System.Collections;

public class BasicAI : MonoBehaviour {
    public int ViewRange, speed, hitrange, AttackDamage, Health;
    private int time, AttackStartTime;
    bool dead;
    GameObject player;
	// Use this for initialization
	void Start () 
    {
        dead = false;
        time = 0;
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (!dead)
        {
            time++;
            if (Vector3.Distance(this.transform.position, player.transform.position) <= ViewRange &&
                Vector3.Distance(this.transform.position, player.transform.position) >= hitrange)
            {
                if (!GetComponent<Animation>().IsPlaying("walk"))
                    GetComponent<Animation>().Play("walk");
                this.transform.LookAt(player.transform);
                this.GetComponent<Rigidbody>().AddForce(this.transform.forward * speed);
            }
            else
                if (Vector3.Distance(this.transform.position, player.transform.position) < hitrange)
                {
                    attack();
                }
            if(Health <= 0)
            {
                die();
            }
        }
	}
    void attack()
    {
        //if (GetComponent<Animation>().IsPlaying("attack") && time  - AttackStartTime % 20 == 0)
        //    player.GetComponentInChildren<inGameGui>().health -= AttackDamage;
        //else
        //{
        //    GetComponent<Animation>().Play("attack");
        //    AttackStartTime = time;
        //}
    }
    IEnumerator die()
    {
        dead = true;
        GetComponent<Animation>().Play("back_fall");
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
