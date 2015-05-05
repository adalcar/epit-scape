using System;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class gui : MonoBehaviour
    {
        private static bool info = false;
        private static string msg = "";
        void OnGUI()
        {
            if (info)
                GUI.Box(new Rect(Screen.width - 200, 5, 195, 100), msg);

        }
        public static IEnumerator dispInfo(string infostring, int time)
        {
            msg = infostring;
            info = true;
            yield return new WaitForSeconds(time);
            info = false;
        }
    }
}
