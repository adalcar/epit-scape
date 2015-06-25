using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Weapon_stuff
{
    public abstract class weaponscriptPere : MonoBehaviour
    {

        protected int ammo, ammocap;
        protected bool UseAmmo;
        public abstract void shoot();
        
        
        public bool reload()
        {
            ammo = ammocap;
            return UseAmmo;
        }

    }
}
