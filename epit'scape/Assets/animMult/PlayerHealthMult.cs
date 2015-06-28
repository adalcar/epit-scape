using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class PlayerHealthMult : MonoBehaviour {

    //public GUISkin skin;
    //public Image mask;
    //public Color good;
    //public Color middle;
    //public Color bad;
    public int startingLife = 100;
    public int currentLife;
    public bool isAttaked;
    public bool isDead;
    Camera cam;

    Animator anim;
    AudioSource playerAudio;
    public float ts;
    public bool isFinished = false;
    GameObject[] tab_en;
    public float time = 0;
    void Awake()
    {
         anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        currentLife = startingLife;
        //mask.GetComponent<Image>().fillAmount = 1;
        //mask.transform.FindChild("Sprite").GetComponent<Image>().color = good;
        Time.timeScale = 1;
        cam = GetComponent<Camera>();
    }
    void Start()
    {
        tab_en = GameObject.FindGameObjectsWithTag("Enemy");
        time = Time.time;
    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 50, 100, 20),"vie : " +currentLife);
        GUI.Box(new Rect(0, 300, 90, 20), "temps: " + time);
       // GUI.Box(new Rect(0, 400, 90, 20), "temps: " + tab_en.Length);
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

    void Update()
    {
        tab_en = GameObject.FindGameObjectsWithTag("Enemy");
        if(tab_en.Length == 0)
        {
            isFinished = true;
        }
        if(!isFinished)
        {
            time += Time.deltaTime;
        }
    }
    public void loseLife(int damages)
    {
        isAttaked = true;
        currentLife -= damages;

        //float lifebar = (float)currentLife / 100f;
        //SetLifeBar(lifebar);
        playerAudio.Play();

        if (currentLife <= 0 && !isDead)
        {
            Debug.Log("ur dead bitch!");
            dead();
        }
    }
    void dead()
    {
        isFinished = true;
        anim.SetTrigger("IsDead");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        this.transform.FindChild("Camera").gameObject.SetActive(false);
        this.cam = GameObject.FindObjectOfType<Camera>();

    }

}
