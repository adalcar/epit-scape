using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.display;
using UnityEngine;
namespace Assets.Scripts.questStuff
{
    class Zombquest
    {
        static string questStart = "recupCles";
        static string questUpdate; 
        static string questfinish = "bien! la porte est ouverte!";
        static int questid = 1;
        static int target = 20;
        public static bool queststarted = false;
        public static bool questcompleted = false;
        public static byte[] to_save(ref int k)
        {
            k = 4;
            byte[] b = new byte[4];
            b[0] = (byte)questid;
            if (queststarted)
                b[1] = 1;
            else
                b[1] = 0;
            if (questcompleted)
                b[2] = 1;
            else
                b[2] = 0;
            return b;
        }
        public static void load(byte[] save, int pos)
        {
            queststarted = save[pos + 1] == 1;
            questcompleted = save[pos + 2] == 1;
        }
        public static int victimes;
        public static void start()
        {
            if (!queststarted)
            {
                queststarted = true;
                GameObject.FindWithTag("MainCamera").GetComponent<inGameGui>().staticInfo(questStart);
            }
        }
    }
}
