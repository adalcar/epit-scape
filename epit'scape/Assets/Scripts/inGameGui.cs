using UnityEngine;
using System.Collections;
using System.IO;
public class inGameGui : MonoBehaviour {
    public int health;
    public GUISkin skin;
    public GameObject terrain, enemy;
    
    string infoLabelText;
    bool infoLabel;
	// Use this for initialization
	void Start () {
        infoLabel = false;
        Cursor.visible = false;
       // Screen.lockCursor = true;
        applyConfigs();
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
	}
    void OnGUI()
    {
        //GUI.Box(new Rect(100, 0, 100, 20), "Vie:" + health);
        if (infoLabel)
        {
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 200, 20), infoLabelText);
        }
            
    }
    public IEnumerable Info(string infostring)
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
