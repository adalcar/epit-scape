using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

    public GameObject cameraF;
    public GameObject cameraE;
    public GameObject image;
    public int speed;
    public int LimitTime;
    public string level;
	
	
	void Update () 
    {
        GameObject camera = Choose();
        camera.transform.Translate(Vector3.down * Time.deltaTime * speed);
        image.transform.Translate(Vector3.down * Time.deltaTime * speed);
        StartCoroutine(WaitFor());
	}

    IEnumerator WaitFor()
    {
        yield return new WaitForSeconds(LimitTime);
        Application.LoadLevel(level);
    }

    GameObject Choose()
    {
        if (Biblio.english == true)
        {
            return cameraE;
        }
        else
        {
            return cameraF;
        }
    }
}
