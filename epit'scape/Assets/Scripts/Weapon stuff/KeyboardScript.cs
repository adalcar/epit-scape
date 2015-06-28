using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Weapon_stuff
{
    class KeyboardScript : weaponscriptPere
    {
        public Camera cam;
        void Start()
        {
        }
        public override void shoot()
        {
            GetComponent<Animation>().Play("clavier");
            
        }
        void OnTriggerEnter(Collider col)
        {
            if(col.tag == "Enemy")
            {
                Debug.Log("hit!");
                col.GetComponent<EnemyHealth>().loseLife(100);
                //col.attachedRigidbody.AddForce(cam.transform.forward);
            }
        }
    }
}
