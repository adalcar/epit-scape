using System;
using System.Collections;
using System.Linq;
using System.Text;
using Assets.Scripts;

namespace Assets.Scripts
{
    class Quest
    {
        protected static string questStart, questUpdate, questfinish;
        protected static int questid, target, count;
        protected static bool queststarted, questcompleted;
        public static byte[] to_save()
        {
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
            b[3] = (byte)count;
            return b;
        }
        public void add()
        {
            if (queststarted && !questcompleted)
            {
                count++;
                if (count == target)
                {
                    gui.dispInfo(questfinish, 2);
                    questcompleted = true;
                }
                else
                    gui.dispInfo(questUpdate, 2);
            }
        }
        public void start()
        {
            if (!queststarted)
            {
                queststarted = true;
                gui.dispInfo(questStart, 4); 
            }
        }
    }
}
