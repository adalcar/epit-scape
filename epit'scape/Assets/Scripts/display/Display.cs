using System;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.display
{
    static class display
    {
        public static bool questdisp, infodisp;
        public static string queststring, infostring;
        public static int ammodisp;
        static IEnumerator questDisplay(string s)
        {
            queststring = s;
            questdisp = true;
            yield return new WaitForSeconds(3);
            questdisp = false;
        }
        public static IEnumerator infodisplay(string s)
        {
            infodisp = true;
            infostring = s;
            yield return new WaitForSeconds(2);
            infodisp = false;
        }
    }
}
