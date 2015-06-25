using UnityEngine;
using System.Collections;

public class PlayerMovmentMulti : MonoBehaviour {

    float speed = 10f;

    Vector3 direction = Vector3.zero;	
    CharacterController characControl;
    Animator anim;
    CapsuleCollider capsCollider;
    float realCapsuleColliderHeight = 2f;
    float jumpCapsuleColliderHeight = 1.2f;
    bool isDancing = false;
    bool isWalking = false;

    void Start()
    {
        characControl = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        capsCollider = GetComponent<CapsuleCollider>();
    }
    void Update()
    {

        
        
        
        
        
        
        
        
        
        //direction = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //if (direction.magnitude > 1f)
        //{
        //    direction = direction.normalized;
        //}
        //anim.SetFloat("Speed", direction.magnitude);


        //if(Input.GetKeyDown("g"))
        //{
            
        //    isDancing = true;
        //    anim.SetBool("IsDancing", true);
        //    isDancing = false;
        //}

        
        
    }

    void FixedUpdate()
    {
        //Vector3 dist = direction * speed * Time.deltaTime;

        //if (characControl.isGrounded)
        //{
        //}
        //else
        //{
        //    verticalVelocity += Physics.gravity.y * Time.deltaTime;
        //}
        //Debug.Log(verticalVelocity);
        //dist.y = verticalVelocity * Time.deltaTime;
        //characControl.Move(dist);
    }
}
