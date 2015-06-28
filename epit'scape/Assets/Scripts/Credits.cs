using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

    public GameObject camera;
    float fin = -380.0f;
	
	void Start()
    { 
        if (Biblio.english == true)
        {
            camera.transform.position = ((camera.transform.position + (Vector3.right * 108))/2);
            Debug.Log("fr");
        }
    }
	void Update () 
    {
        
        camera.transform.position = (camera.transform.position + Vector3.down);

        if (camera.transform.position.y == fin)
        {
            Application.LoadLevel("MainMenu");
        }
        
        Debug.Log("Bon");
        Debug.Log(camera.transform.position);

        
    
	}
}
