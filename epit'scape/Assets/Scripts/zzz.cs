using UnityEngine;
using System.Collections;

public class zzz : MonoBehaviour {
    public int vie = 100;
    public GameObject obj;
	// Use this for initialization
	void Start () {
	}
    void OnGui(){
        GUI.Box(new Rect(1000, 0, 100, 20), "Vie:" + this.vie);
    }
	
	// Update is called once per frame
	void Update () 
    {
	
        if(vie <= 0)
        {
            vie = 0;
            Destroy(this.obj);
        }

        if(Input.GetKeyDown("e"))
        {
            vie -= 10;
        }
	}
    void OnGUI()
    {
        GUI.Box(new Rect(1000, 0, 100, 20), "Vie:" + vie);
    }
    void healthRegen()
    {
        //for (int i = 0; i > 0; i++)
        //{
        //    StartCoroutine("wait");
        //    if(vie < 100)
        //    {
        //        vie++;
        //    }
        //}

    }
    //IEnumerator wait()
    //{
    //    yield return new WaitForSeconds(0.5f);
    //    print("soin");
    //}

    
}
