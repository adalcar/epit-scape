using System;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Weapon_stuff
{
    class PenScript : weaponscriptPere
    {
        public GameObject camObject;
        private Camera cam;
        public GameObject projectile;
        bool canshoot;
        void Start()
        {
            cam = camObject.GetComponent<Camera>();
            ammocap = 20;
            ammo = 20;
            canshoot = true;
        }
        public override void shoot()
        {
            if (ammo != 0 && canshoot)
            {
                GameObject bullet = (GameObject)Instantiate(projectile, transform.position, transform.rotation);
                bullet.GetComponent<Rigidbody>().AddForce(camObject.transform.forward * 5, ForceMode.Impulse);
                StartCoroutine(loadWait());
            }
        }
        IEnumerator loadWait()
        {
            canshoot = false;
            yield return new WaitForSeconds(.5F);
            canshoot = true;
        }
    }
}
