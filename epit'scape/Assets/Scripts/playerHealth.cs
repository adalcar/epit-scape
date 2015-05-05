using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour {
    public GUISkin skin;
    public int startingLife = 100;                           
    public int currentLife;
    public bool isAttaked;
    bool isDead;
    public Texture deadback;
    //Animator anim;
    AudioSource playerAudio; 
   
    void Awake()
    {
       // anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        currentLife = startingLife;
    }

	void Update () 
    {
	}
    void OnGUI()
    {
        GUI.Box(new Rect(0, 50, 100, 20),"vie : " +currentLife);
    }
    public void loseLife(int damages)
    {
        isAttaked = true;
        currentLife -= damages;
        //healthSlider.value = currentLife;
        playerAudio.Play();

        if (currentLife <= 0 && !isDead)
        {
            dead();
        }
    }
    void dead()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        Assets.Scripts.playerdata.scene = Application.loadedLevelName;
        Application.LoadLevel("gameOver");
    }
    void restart()
    {
        StartCoroutine(wait());
        Application.LoadLevel("Level 01");
    }

    IEnumerator wait()
    {
      yield return new WaitForSeconds(5.0f);
      print("respawn");
      restart();
    }
}
