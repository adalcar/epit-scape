using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MultiPlayerHealth : MonoBehaviour {

    public GUISkin skin;
   // public Image mask;
    public Color good;
    public Color middle;
    public Color bad;
    public int startingLife = 100;
    public int currentLife;
    public bool isAttaked;
    bool isDead;
    public Texture deadback;
    Animator anim;
    AudioSource playerAudio;

	// Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        currentLife = startingLife;
        //mask.GetComponent<Image>().fillAmount = 1;
        //mask.transform.FindChild("Sprite").GetComponent<Image>().color = good;

    }
	// Update is called once per frame

    public void loseLife(int damages)
    {
        isAttaked = true;
        currentLife -= damages;

        float lifebar = (float)currentLife / 100f;
       // SetLifeBar(lifebar);
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
     //   this.transform.FindChild("Main Camera").gameObject.SetActive(false);
    }


    //void SetLifeBar(float value)
    //{
    //    mask.GetComponent<Image>().fillAmount = value;

    //    if (value >= 0.5f)
    //    {
    //        mask.transform.FindChild("Sprite").GetComponent<Image>().color = good;
    //    }
    //    else if (value >= 0.25f)
    //    {
    //        mask.transform.FindChild("Sprite").GetComponent<Image>().color = middle;
    //    }
    //    else
    //    {
    //        mask.transform.FindChild("Sprite").GetComponent<Image>().color = bad;
    //    }
    //}
}
