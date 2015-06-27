using UnityEngine;
using System.Collections;
using System.IO;

public class inGameGui : MonoBehaviour {
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
        Cursor.lockState = CursorLockMode.Confined;
        applyConfigs(); 
        menu = false;
        options = false;
        savemenu = false;
        cameras = GetComponentsInParent<MouseLook>();
        Time.timeScale = 1;

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

        if (Input.GetButtonDown("menu"))
        {
            if (!menu)
            {
                foreach (MouseLook m in cameras)
                    m.enabled = false;
                Cursor.visible = true;
                Time.timeScale = 0;
                menu = true;
                if (options)
                {
                    Configfs.Close();
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
        if (menu || options || savemenu)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), menuback);
            GUI.Label(new Rect(Screen.width / 2 - 100, 100, 200, 50), menupause);
        }
        option();
        save_menu();

        if (infoLabel)
        {
            GUI.Box(new Rect(Screen.width - 100, 5, 100,60), Biblio.Text(infoLabelText));
        }
        #region menu
        if (menu)
        {
            menupause = "pause";

            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 200, 300, 50), Biblio.Text("retJeu")))
            {
                foreach (MouseLook m in cameras)
                    m.enabled = true;
                Time.timeScale = 1;
                menu = false;
                GetComponent<MouseLook>().menu();
            }
            if(GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 50), "Options"))
            {
                menu = false;
                options = true;
                Configfs = new FileStream("Saves and Config/Config", FileMode.Open, FileAccess.Read);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 200, Screen.height / 2, 400, 50), Biblio.Text("savquit")))
            {
                savemenu = true;
                menu = false;

            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 100, 200, 50), "exit to menu"))
            {
                savemenu = true;
                menu = false;
                Application.LoadLevel("MainMenu");
            }
        }
        #endregion
    }
    void save_menu()
    {
        if (savemenu)
        {
            menupause = "save";
            if(GUI.Button (new Rect(Screen.width/2 - 100, Screen.height / 2 - 50, 200, 50), "Save 1"))
            {
                savegame(1);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2  + 50, 200, 50), "Save 2"))
            {
                savegame(2);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 150, 200, 50), "Save 3"))
            {
                savegame(3);
            }
            if (GUI.Button(new Rect(10, 20, 120, 45), Biblio.Text("back")))
            {
                savemenu = false;
                menu = true;
            }
        }
    }
    void option()
    {

        if (options)
        {
            Configfs.Position = 0;
            int soundlvl = Configfs.ReadByte();
            menupause = "option";

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
        yield return new WaitForSeconds(10);
        infoLabel = false;
    }
    
    void savegame(int save_number)
    {

        string savename = "Saves and Config/Save_" + save_number;
        if(File.Exists(savename))
        {
            //todo: voulez-vous vraiment sauvegarder?
        }
        int pos = 0;
        int k = 0;
        byte[] save = new byte[1024];
        Assets.Scripts.playerdata.toSave(ref k).CopyTo(save, pos);
        pos += k;
        Assets.Scripts.questStuff.keyQuest.to_save(ref k).CopyTo(save, pos);
        pos += k;
            //todo: add other things to save? 
        File.WriteAllBytes(savename, save);
        Application.LoadLevel("MainMenu");
    }
    

}
