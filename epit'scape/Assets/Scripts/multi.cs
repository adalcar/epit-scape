using UnityEngine;
using System.Collections;

public class multi : MonoBehaviour {

    int nb = 0;
	
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
    void OnTriggerEnter(Collider coll   )
    {
        if(coll.tag == "Player")
        {
            Debug.Log("Start");
            startLevel();
        }
    }
    private void startLevel()
    {
        if(nb < 10)
        {
            for(int i = 0; i < 10; i++)
            {

                GameObject[] spawners = GameObject.FindGameObjectsWithTag("spawn");
                GameObject spawn = spawners[i];
                Network.Instantiate(Resources.Load("zomb"), spawn.transform.position, Quaternion.identity, 0);
            }
        }
        
    }

}
