using UnityEngine;
using System.Collections;
using System.IO;

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
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 30, 200, 50), Biblio.Text("saved")))
            {

            }
        }
    }
    void LevelSelectMenu()
    {
        if (_isLevelSelectMenu)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 30, 300, 50), Biblio.Text("lvl1")))
            {
                Application.LoadLevel("Level 01");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 60, 300, 50), Biblio.Text("lvl0")))
            {
                Application.LoadLevel("level 0");
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
    void OnApplicationQuit()
    {
        Debug.Log("quit");
        Configfs.Close();
    }
}
