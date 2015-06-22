using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts
{
    class playerdata
    {
        public static int life;
        public static Vector3 playerpos;
        public static int scene;
        public static bool loadedfromsave;
        public static byte[] toSave(ref int pos)
        {
            pos = 5;
            return new byte[5] { (byte)scene, (byte)(playerpos.x * 10), (byte)(playerpos.y * 10), (byte)(playerpos.z * 10), (byte)life };
        }
        public static void load(byte[] save, int pos)
        {
            scene = save[pos];
            Application.LoadLevel(scene);
            playerpos.x = save[pos + 1] / 10;
            playerpos.y = save[pos + 2] / 10;
            playerpos.z = save[pos + 3] / 10;
            life = save[pos + 4];
        }
    }
}
