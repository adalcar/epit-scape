using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
    public float lapsTime = 3.0f;
    public int damages = 20;

    Animator anim;
    GameObject player;                         
    EnemyHealth enemyHealth;                        
    playerHealth playerHealth;           
    bool isInRange;                    
    float timer;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemyHealth = GetComponent<EnemyHealth>();
        playerHealth = player.GetComponent<playerHealth>();
        anim = GetComponent<Animator>();
        isInRange = false;
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Debug.Log("touche!");
            isInRange = !isInRange;
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Debug.Log("nohit!");
            isInRange = !isInRange;
            anim.SetBool("IsWalking", true);
        }
    }
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        if (timer >= lapsTime && isInRange && enemyHealth.currentLife > 0)
        {
            Attack();
        }
        if(!isInRange)
        {
            anim.SetBool("IsInRange", false);
        }
        //if (playerHealth.currentLife <= 0)
        //{
        //    anim.SetTrigger("GameOver");
        //}

	
	}

    void Attack()
    {
        timer = 0f;

        if (playerHealth.currentLife > 0)
        {
            playerHealth.loseLife(damages);
            anim.SetBool("IsInRange", isInRange);
        }
    }
}
