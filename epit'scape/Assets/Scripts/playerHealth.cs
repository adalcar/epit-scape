using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {
    public GUISkin skin;
    public GameObject healthBar;
    public Color good;
    public Color middle;
    public Color bad;
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
        //GUI.Box(new Rect(0, 50, 100, 20),"vie : " +currentLife);
    }
    public void loseLife(int damages)
    {
        isAttaked = true;
        currentLife -= damages;

        float lifebar = (float)currentLife / 100f;
        SetLifeBar(lifebar);
        //healthSlider.value = currentLife;
        playerAudio.Play();

        if (currentLife <= 0 && !isDead)
        {
            dead();
        }
    }

    void SetLifeBar(float value)
    {
        healthBar.GetComponent<Scrollbar>().size = value;

        if(value >= 0.5f)
        {
            healthBar.transform.FindChild("Mask").FindChild("Sprite").GetComponent<Image>().color = good;
        }
        else if(value >= 0.25f)
        {
            healthBar.transform.FindChild("Mask").FindChild("Sprite").GetComponent<Image>().color = middle;
        }
        else
        {
            healthBar.transform.FindChild("Mask").FindChild("Sprite").GetComponent<Image>().color = bad;
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
