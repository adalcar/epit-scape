using UnityEngine;
using System.Collections;
using System.IO;
public class inGameGui : MonoBehaviour {
    public int health;
    public GUISkin skin;
    public GameObject terrain, enemy;
    public Texture menuback;
    string infoLabelText;
    bool infoLabel;
    bool menu;

	// Use this for initialization
	void Start () 
    {
        infoLabel = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        applyConfigs();
        menu = false;
	}
    void applyConfigs()
    {
        FileStream f = new FileStream("Saves and Config/Config", FileMode.Open, FileAccess.Read);
        
        this.GetComponent<AudioSource>().volume = ((float) f.ReadByte() )/ 100;
        
        f.Close();
    }
	// Update is called once per frame
	void Update () 
    {

        if (health <= 0)
        {
            death();
        }
        if (Input.GetButtonDown("menu"))
        {
            if (!menu)
            {
                Time.timeScale = 0;
                menu = true;
            }
            else
            {
                Time.timeScale = 1;
                menu = false;
            }
            GetComponent<MouseLook>().menu();
        }

	}
    void OnGUI()
    {
        if (infoLabel)
        {
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 200, 40), infoLabelText);
        }
        #region menu
        if (menu)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), menuback);
            GUI.Label(new Rect(Screen.width / 2 - 100, 100, 200, 50), "pause");
        }
        #endregion
    }
    public IEnumerator Info(string infostring)
    {
        Debug.Log("spot!");
        infoLabelText = infostring;
        infoLabel = true;
        yield return new WaitForSeconds(2);
        infoLabel = false;
    }
    void death()
    {
        
    }
    

}
