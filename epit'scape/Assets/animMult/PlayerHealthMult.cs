using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class PlayerHealthMult : MonoBehaviour {

    public GUISkin skin;
    public Image mask;
    public Color good;
    public Color middle;
    public Color bad;
    public int startingLife = 100;
    public int currentLife;
    public bool isAttaked;
    bool isDead;
    Camera cam;

    Animator anim;
    AudioSource playerAudio;
    public float ts;
    void Awake()
    {
         anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        currentLife = startingLife;
        mask.GetComponent<Image>().fillAmount = 1;
        mask.transform.FindChild("Sprite").GetComponent<Image>().color = good;
        Time.timeScale = 1;
        cam = GetComponent<Camera>();
    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 50, 100, 20),"vie : " +currentLife);
        GUI.Box(new Rect(300, 350, 100, 20), "vie : " + currentLife);
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
            Debug.Log("ur dead bitch!");
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
        anim.SetTrigger("IsDead");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        this.transform.FindChild("Camera").gameObject.SetActive(false);
        this.cam = GameObject.FindObjectOfType<Camera>();
    }

}
