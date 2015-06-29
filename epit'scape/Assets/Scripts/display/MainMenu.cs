using UnityEngine;
using System.Collections;
using System.IO;
using Assets.Scripts.questStuff;
public class MainMenu : MonoBehaviour {
    private bool _isFirstMenu = true;
    private bool _isLevelSelectMenu = false;
    private bool _isOptionMenu = false;
    private bool _isLoadGameMenu = false;
    private string title;
    public string gameTitle = "Name This Game";
    public Texture background1;
    public GUISkin myskin;
    FileStream Configfs;

	// Use this for initialization
	void Start () 
    {
        checkfolders();

        title = gameTitle;
        Biblio.english = true;
	}
    void checkfolders()
    {
        checkConfigFile();
        if (!Directory.Exists("Saves and Config/Saves"))
            Directory.CreateDirectory("Saves and Config/Saves");

    }
	// Update is called once per frame
	void Update () 
    {
         
	}
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background1);
        GUI.skin = myskin;
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 200, 200, 50), gameTitle);
        FirstMenu();
        LoadGameMenu();
        LevelSelectMenu();
        OptionMenu();
        if (!_isFirstMenu)
        {
            if (GUI.Button(new Rect(10, 20, 120, 45), Biblio.Text("back")))
            {
                gameTitle = title;
                _isLevelSelectMenu = false;
                _isLoadGameMenu = false;
                _isOptionMenu = false;
                _isFirstMenu = true;
            }
        }
    }
    void checkConfigFile()
    {
        FileStream f = new FileStream("Saves and Config/Config", FileMode.OpenOrCreate);
        int l = (int) f.Length;
        f.Close();

        if (l != 1)
            File.WriteAllBytes("Saves and Config/Config", new byte[1] { 100 });

        Configfs = new FileStream("Saves and Config/Config", FileMode.Open,FileAccess.ReadWrite,FileShare.Read);
    }
    void FirstMenu()
    {
        if (_isFirstMenu)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 100, 300, 50), Biblio.Text("newgame")))
            {
                Application.LoadLevel("level 0");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 50, 300, 50), Biblio.Text("load")))
            {
                gameTitle = Biblio.Text("load");
                _isFirstMenu = false;
                _isLoadGameMenu = true;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2, 300, 50), Biblio.Text("select")))
            {
                gameTitle = Biblio.Text("selectlvl");
                _isFirstMenu = false;
                _isLevelSelectMenu = true;
            } if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 50, 300, 50), Biblio.Text("mult")))
            {
                Application.LoadLevel("multi");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 100, 300, 50), "Options"))
            {
                gameTitle = "Options";
                _isFirstMenu = false;
                _isOptionMenu = true;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 150, 300, 50), Biblio.Text("quit")))
            {
                Application.Quit();
            }
        }
    }
    void LoadGameMenu()
    {
        if (_isLoadGameMenu)
        {

            GUI.enabled = File.Exists("Saves and Config/Save_1");
            if (GUI.Button(new Rect(Screen.width / 2 + 100, Screen.height / 2 - 70, 200, 50), Biblio.Text("del")))
            {
                File.Delete("Saves and Config/Save_1");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 70, 200, 50), Biblio.Text("save") + 1))
            {
                loadlevelfromfile(1);
            }
            GUI.enabled = File.Exists("Saves and Config/Save_2");
            if (GUI.Button(new Rect(Screen.width / 2 + 100, Screen.height / 2 + 30, 200, 50), Biblio.Text("del")))
            {
                File.Delete("Saves and Config/Save_2");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 30, 200, 50), Biblio.Text("save") + 2))
            {
                loadlevelfromfile(2);
            }
            GUI.enabled = File.Exists("Saves and Config/Save_3");
            if (GUI.Button(new Rect(Screen.width / 2 + 100, Screen.height / 2 + 130, 200, 50), Biblio.Text("del")))
            {
                File.Delete("Saves and Config/Save_3");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 130, 200, 50), Biblio.Text("save") + 3))
            {
                loadlevelfromfile(3);
            }
            GUI.enabled = true;
        }
    }
    void LevelSelectMenu()
    {
        if (_isLevelSelectMenu)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 300, Screen.height / 2 - 100, 150, 50), Biblio.Text("out")))
            {
                Application.LoadLevel("level 0");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 300, Screen.height / 2 - 30, 150, 50), Biblio.Text("lvl0")))
            {
                Application.LoadLevel("level 1");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 300, Screen.height / 2 + 40, 150, 50), Biblio.Text("lvl1")))
            {
                Application.LoadLevel("Level 2");
            }


            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 150, 50), Biblio.Text("lvl2")))
            {
                Application.LoadLevel("Etage2");
                Penquest.questcompleted = true;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 30, 150, 50), Biblio.Text("lvl3")))
            {
                Application.LoadLevel("etage3");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 40, 150, 50), Biblio.Text("boc")))
            {
                Application.LoadLevel("Bocal");
            }
            if (GUI.Button(new Rect(Screen.width / 2 + 100, Screen.height / 2 - 100, 150, 50), Biblio.Text("outB")))
            {
                Application.LoadLevel("level 0boss");
            }
            if (GUI.Button(new Rect(Screen.width / 2 + 100, Screen.height / 2 - 30, 150, 50), "Pasteur"))
            {
                Application.LoadLevel("pasteur");
            }
            if (GUI.Button(new Rect(Screen.width / 2 + 100, Screen.height / 2 + 40, 150, 50),"Under"))
            {
                Application.LoadLevel("under");
            }
        }
    }
    void OptionMenu()
    {
        Configfs.Position = 0;
        int soundlvl = Configfs.ReadByte();
        if (_isOptionMenu)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 30, 200, 50), Biblio.Text("lang")))
            {
                Biblio.english = !(Biblio.english);
            }


            soundlvl = (int) GUI.HorizontalSlider(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 100, 400, 20), soundlvl, 0, 100);
            Configfs.Position = 0;
            Configfs.WriteByte((byte)soundlvl);
        }
    }
    void loadlevelfromfile(int file)
    {
        string filename = "Saves and Config/Save_" + file;
        byte[] loaded = File.ReadAllBytes(filename);
        Assets.Scripts.playerdata.loadedfromsave = true;
        Assets.Scripts.playerdata.load(loaded, 0);
        Assets.Scripts.questStuff.keyQuest.load(loaded, 5);
        Bananalauncherquest.load(loaded, 17);
        KeyboardQuest.load(loaded, 13);
        Penquest.load(loaded, 9);
    }
    void OnApplicationQuit()
    {
        Debug.Log("quit");
        Configfs.Close();
    }
}
