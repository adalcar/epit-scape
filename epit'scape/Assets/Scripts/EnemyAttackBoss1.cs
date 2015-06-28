using UnityEngine;
using System.Collections;

public class EnemyAttackBoss1 : MonoBehaviour {
    public float lapsTime = 3.0f;
    public int damages = 20;
    public static bool attacked = false;

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


    // Update is called once per frame
    void Update()
    {
        #region playerdetect
        isInRange = Vector3.Distance(transform.position, player.transform.position) < 6.5F;
        GetComponent<Boss1IA>().enabled = !isInRange;
        #endregion

        timer += Time.deltaTime;
        if (timer > lapsTime && isInRange && enemyHealth.currentLife > 0)
        {
            Attack();
        }

        if (isInRange && !GetComponent<EnemyHealth>().isDead)
            transform.LookAt(player.transform.position - new Vector3(0, player.transform.position.y + 2.5F, 0));

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
            Debug.Log("get hurt biatch");
            playerHealth.loseLife(damages);
            anim.SetBool("IsInRange", isInRange);
            attacked = true;
        }
    }
}
