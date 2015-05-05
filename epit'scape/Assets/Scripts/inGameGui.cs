using UnityEngine;
using System.Collections;
using System.IO;

public class inGameGui : MonoBehaviour {
    public int health;
    public GUISkin skin;
    public GameObject terrain, enemy;
    public Texture menuback;
    private MouseLook[] cameras;
    string infoLabelText;
    string menupause;
    FileStream Configfs;
    #region guibools
    bool infoLabel;
    bool menu;
    bool savemenu;
    bool options;
    #endregion
    // Use this for initialization
	void Start () 
    {
        menu = true;
        infoLabel = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        applyConfigs();
        menu = false;
        options = false;
        savemenu = false;
        cameras = GetComponentsInParent<MouseLook>();
        

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
                foreach (MouseLook m in cameras)
                    m.enabled = false;
                if (!options && !savemenu)
                    Configfs = new FileStream("Saves and Config/Config", FileMode.Open, FileAccess.Read);
                Cursor.visible = true;
                Time.timeScale = 0;
                menu = true;
                if (options)
                {
                    options = false;
                    GetComponent<MouseLook>().menu();
                }
                if (savemenu)
                {
                    savemenu = false;
                    GetComponent<MouseLook>().menu();
                }
            }
            else
            {
                foreach (MouseLook m in cameras)
                    m.enabled = true;
                Configfs.Close();
                Cursor.visible = false;
                Time.timeScale = 1;
                menu = false;
            }
            GetComponent<MouseLook>().menu();
        }
        
	}
    void OnGUI()
    {
        GUI.skin = skin;
        option();

        if (infoLabel)
        {
            GUI.Box(new Rect(Screen.width - 100, 5, 100,60), Biblio.Text(infoLabelText));
        }
        #region menu
        if (menu)
        {
            menupause = "pause";
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), menuback);
            GUI.Label(new Rect(Screen.width / 2 - 100, 100, 200, 50), menupause);
            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 200, 300, 50), Biblio.Text("retJeu")))
            {
                foreach (MouseLook m in cameras)
                    m.enabled = true;
                Configfs.Close();
                Time.timeScale = 1;
                menu = false;
                GetComponent<MouseLook>().menu();
            }
            if(GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 50), "Options"))
            {
                menu = false;
                options = true;
            }
            //if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2, 200, 50), Biblio.Text("savquit")))
            //{
            //    savemenu = true;
            //    menu = false;
            //    DirectoryInfo d = new DirectoryInfo("Saves and Config/Saves");
            //    foreach()
                
            //    savegame();
            //}
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2, 200, 50), "exit to menu"))
            {
                savemenu = true;
                menu = false;
                Application.LoadLevel("MainMenu");
            }
        }
        #endregion
    }
    void option()
    {



        if (options)
        {
            Configfs.Position = 0;
            int soundlvl = Configfs.ReadByte();
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), menuback);
            menupause = "option";
            GUI.Label(new Rect(Screen.width / 2 - 100, 100, 200, 50), menupause);

            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 30, 200, 50), Biblio.Text("lang")))
            {
                Biblio.english = !(Biblio.english);
            }


            soundlvl = (int)GUI.HorizontalSlider(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 100, 400, 20), soundlvl, 0, 100);
            Configfs.Position = 0;
            Configfs.WriteByte((byte)soundlvl);
        }
    }
    public void staticInfo(string infostring)
    {
        StartCoroutine(Info(infostring));
    }
    public IEnumerator Info(string infostring)
    {
        
        infoLabelText = infostring;
        infoLabel = true;
        yield return new WaitForSeconds(2);
        infoLabel = false;
    }
    
    void death()
    {
    }
    void savegame(string name)
    {

    }
    

}
