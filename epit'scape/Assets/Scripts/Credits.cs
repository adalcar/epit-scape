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
        camera.transform.Translate(Vector3.down * Time.deltaTime * speed);
        StartCoroutine(WaitFor());
	}

    IEnumerator WaitFor()
    {
        yield return new WaitForSeconds(20);
        Application.LoadLevel(level);
    }

    //void Choose()
   // {
      //  if (Biblio.english == true)
      //  {
     //       camera.transform.TransformPoint(0, 0, 0);
     //   }
   // }
}
