using UnityEngine;
using System.Collections;
using System.IO;
public class inGameGui : MonoBehaviour {
    public GUISkin skin;
    bool infoLabel;
    public GameObject terrain;
    string infoLabelText;
    public GameObject enemy;
	// Use this for initialization
	void Start () {
        infoLabel = false;
        Screen.showCursor = false;
        Screen.lockCursor = true;
        applyConfigs();
	}
    void applyConfigs()
    {
        FileStream f = new FileStream("Saves and Config/Config", FileMode.Open, FileAccess.Read);
        
        this.audio.volume = ((float) f.ReadByte() )/ 100;
        
        f.Close();
    }
	// Update is called once per frame
	void Update () 
    {

	}
    void OnGUI()
    {
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
}
