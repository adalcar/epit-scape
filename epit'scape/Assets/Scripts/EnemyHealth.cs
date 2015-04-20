using UnityEngine;
using System.Collections;


public class EnemyHealth : MonoBehaviour {
    public int startLife = 100;
    public int currentLife;
    //public AudioClip deathClip; // a ajouter

    public Animator anim;
    //AudioSource enemyAudio;// a ajouter
    //CapsuleCollider capColl;
    bool isDead;
    void Awake()
    {
        anim = GetComponent<Animator>();
        //enemyAudio = GetComponent <AudioSource> ();
        //capColl = GetComponent<CapsuleCollider>();
        currentLife = startLife;

    }
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        
        //if (life <= 0)
        //    StartCoroutine(death());

	}
    //IEnumerator death()
    //{
    //    anim.Play("dead");
    //    yield return new WaitForSeconds(1);
    //    Destroy(this.gameObject);
    //}
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
            Dead();
        }
    }
    public void Dead()
    {
        isDead = true;
        //capColl.isTrigger = true;
        anim.SetTrigger("IsDead");
        Destroy(gameObject, 2f);

    }

}
