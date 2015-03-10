using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour
{
    public string target;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void onTriggerEnter(Collider c)
    {
        Debug.Log("contact");
        if (c.tag == "Player")
        {
            Application.LoadLevel(target);
        }
    }
}
