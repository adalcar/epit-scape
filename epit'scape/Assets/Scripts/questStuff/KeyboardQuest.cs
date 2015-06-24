using UnityEngine;
using System.Collections;

public static class KeyboardQuest {

    public static string questStart, questUpdate, questfinish;
    static int questid = 3;
    static int target = 1;
    static int count = 0;
    public static bool queststarted = false;
    public static bool questcompleted = false;
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
    public static void add()
    {
        if (queststarted && !questcompleted)
        {
            count++;
            if (count == target)
            {
                GameObject.FindWithTag("MainCamera").GetComponent<inGameGui>().Info(questfinish);
                questcompleted = true;
            }
            else
                GameObject.FindWithTag("MainCamera").GetComponent<inGameGui>().Info(questUpdate);
        }
    }
    public static void start()
    {
        if (!queststarted)
        {
            queststarted = true;
            GameObject.FindWithTag("MainCamera").GetComponent<inGameGui>().staticInfo(questStart);
        }
    }
}
