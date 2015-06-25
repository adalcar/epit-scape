using System;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Weapon_stuff
{
    class bananalauncherscript : weaponscriptPere
    {
        public GameObject camObject;
        private Camera cam;
        public GameObject projectile;
        bool canshoot;
        void Start()
        {
            canshoot = true;
            cam = camObject.GetComponent<Camera>();
            ammocap = 20;
            ammo = 20;
        }
        public override void shoot()
        {
            if (ammo != 0 && canshoot)
            {
                GameObject bullet = (GameObject)Instantiate(projectile, transform.position, transform.rotation);
                bullet.GetComponent<Rigidbody>().AddForce(camObject.transform.forward * 20, ForceMode.Impulse);
                StartCoroutine(loadWait());
            }
        }
        IEnumerator loadWait()
        {
            canshoot = false;
            yield return new WaitForSeconds(0.2F);
            canshoot = true;
        }
    }
}
