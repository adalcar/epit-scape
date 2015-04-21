using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour {

    public int startingLife = 100;                           
    public int currentLife;
    bool isAttaked;
    bool isDead;
    //Animator anim;
    //AudioSource playerAudio; 
   
    void Awake()
    {
       // anim = GetComponent<Animator>();
        //playerAudio = GetComponent<AudioSource>();
        currentLife = startingLife;
    }

	void Update () 
    {
	
	}

    public void loseLife(int damages)
    {
        isAttaked = true;
        currentLife -= damages;
        //healthSlider.value = currentLife;
        //playerAudio.Play();

        if (currentLife <= 0 && !isDead)
        {
            dead();
        }
    }
    void dead()
    {
        isDead = true;
        //anim.SetTrigger("Die");
        Destroy(this.gameObject);
        restart();
    }
    void restart()
    {
        Application.LoadLevel("Level 01");
    }
}
