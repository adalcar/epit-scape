using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

    public GameObject camera;
    public int speed = 1;
    //public int LimitTime;
    public string level;
	
	
	void Update () 
    {
        //Choose();
        camera.transform.position = (camera.transform.position + Vector3.down);
        
        Debug.Log("Bon");
        Debug.Log(camera.transform.position);
       // StartCoroutine(WaitFor());
	}

    IEnumerator WaitFor()
    {
        yield return new WaitForSeconds(20);
        Application.LoadLevel("MainMenu");
    }

    //void Choose()
   // {
      //  if (Biblio.english == true)
      //  {
     //       camera.transform.TransformPoint(0, 0, 0);
     //   }
   // }
}
