using UnityEngine;
using System.Collections;

public class Boss2Tir : MonoBehaviour
{
    public GameObject target;
    public Transform bullet;
    public GameObject posCanon;
    float cadence = 1f;
    bool pause = true;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 vise = - posCanon.transform.position + target.transform.position;

        if (Time.timeScale != 0 && pause)
        {
            Transform balle;
            balle = Instantiate(bullet, posCanon.transform.position, posCanon.transform.rotation) as Transform;
            balle.GetComponent<Rigidbody>().AddForce((vise + Vector3.up / 5) * 500);
            pause = false;
            Debug.Log("tir");
            StartCoroutine(StartWait());
        }
	}

    IEnumerator StartWait()
    {
        yield return new WaitForSeconds(cadence);
        pause = true;
    }
}
