using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts
{
    class playerdata
    {
        public static int life, penAmmo, gunAmmo;
        public static Vector3 playerpos;
        public static int scene;
        public static bool loadedfromsave;
        public static byte[] toSave(ref int pos)
        {
            pos = 5;
            return new byte[5] { (byte)scene, (byte)(playerpos.x), (byte)(playerpos.y), (byte)(playerpos.z), (byte)gunAmmo };
        }
        public static void load(byte[] save, int pos)
        {
            scene = save[pos];
            playerpos.x = (sbyte)save[pos + 1];
            playerpos.y = (sbyte)save[pos + 2];
            playerpos.z = (sbyte)save[pos + 3];
            Application.LoadLevel(scene);
            life = save[pos + 4];
        }
    }
}
