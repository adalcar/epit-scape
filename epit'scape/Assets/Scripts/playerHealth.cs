using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {
    public GUISkin skin;
    public Image mask;
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
        //mask.GetComponent<Image>().fillAmount = 1;
        //mask.transform.FindChild("Sprite").GetComponent<Image>().color = good;

        if (Assets.Scripts.playerdata.loadedfromsave)
        {
            transform.position = Assets.Scripts.playerdata.playerpos;
            Assets.Scripts.playerdata.loadedfromsave = false;
        }
        else
            Assets.Scripts.playerdata.scene = Application.loadedLevel;

    }

	void Update () 
    {
        Assets.Scripts.playerdata.playerpos = transform.position;
        Assets.Scripts.playerdata.life = currentLife;
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
        playerAudio.Play();

        if (currentLife <= 0 && !isDead)
        {
            dead();
        }
    }

    void SetLifeBar(float value)
    {
        mask.GetComponent<Image>().fillAmount = value;

        if (value >= 0.5f)
        {
            mask.transform.FindChild("Sprite").GetComponent<Image>().color = good;
        }
        else if (value >= 0.25f)
        {
            mask.transform.FindChild("Sprite").GetComponent<Image>().color = middle;
        }
        else
        {
            mask.transform.FindChild("Sprite").GetComponent<Image>().color = bad;
        }
    }

    void dead()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        Assets.Scripts.playerdata.scene = Application.loadedLevel;
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
