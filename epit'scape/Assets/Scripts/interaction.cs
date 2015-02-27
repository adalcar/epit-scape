using UnityEngine;
using System.Collections;

public class interaction : MonoBehaviour {

    private Ray interactRay;
    private int range = 10;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        interactRay.origin = transform.position;
        interactRay.direction = transform.forward;
        RaycastHit interact;
        if (Physics.Raycast(interactRay, out interact, range))
        {
            if (interact.transform.tag == "door")
                transform.GetComponent<inGameGui>().Info("press x to open/close");
        }
    }
}
