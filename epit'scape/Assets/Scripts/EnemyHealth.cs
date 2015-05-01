using UnityEngine;
using System.Collections;


public class EnemyHealth : MonoBehaviour {
    public int startLife = 100;
    public int currentLife;
    NavMeshAgent nav;
    //public AudioClip deathClip; // a ajouter

    public Animator anim;
    //AudioSource enemyAudio;// a ajouter
    //CapsuleCollider capColl;
    public bool isDead;

    void Awake()
    {
        anim = GetComponent<Animator>();
        //enemyAudio = GetComponent <AudioSource> ();
        //capColl = GetComponent<CapsuleCollider>();
        currentLife = startLife;
        nav = GetComponent<NavMeshAgent>();
    }
    void OnGui()
    {
        GUI.Box(new Rect(0, 100, 60, 60), "vie :" + currentLife);
    }
	// Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "bullet")
        {
            Debug.Log("hit!");
            loseLife(coll.GetComponent<bullet>().degats);
        }
    }
    
    public void loseLife(int dammage)
    {
        if(isDead)
        {
            return;
        }
        //enemyAudio.Play();
        currentLife -= dammage;
        if(currentLife <= 0 )
        {
            currentLife = 0;
            Dead();
        }
    }
    public void Dead()
    {
        isDead = true;
        nav.enabled = false;
        //GameObject.FindWithTag("Player").GetComponent<QuestManager>().current_score++;
        anim.SetTrigger("IsDead");
        Destroy(gameObject);
    }

}
