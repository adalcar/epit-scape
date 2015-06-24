using System;
using System.Collections.Generic;
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
        void Start()
        {
            cam = camObject.GetComponent<Camera>();
            ammocap = 20;
        }
        public override void shoot()
        {
            if (ammo != 0)
            {

            }
        }
    }
}
