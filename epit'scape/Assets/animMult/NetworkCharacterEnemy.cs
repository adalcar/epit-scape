using UnityEngine;
using System.Collections;

public class NetworkCharacterEnemy : Photon.MonoBehaviour {

    Vector3 currentPosition = Vector3.zero;
    Quaternion currentRotation = Quaternion.identity;

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        if (anim == null)
        {
            Debug.LogError("prefab!");
        }
    }


    void Update()
    {

         transform.position = Vector3.Lerp(transform.position, currentPosition, 0.1f);
         transform.rotation = Quaternion.Lerp(transform.rotation, currentRotation, 0.1f);
    }
}
