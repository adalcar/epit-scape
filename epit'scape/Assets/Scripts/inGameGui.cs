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
        Cursor.lockState = CursorLockMode.Locked;
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
