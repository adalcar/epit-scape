using UnityEngine;
using System.Collections;

public static class Bananalauncherquest{

    public static string questStart, questUpdate, questfinish;
    static int questid = 4;
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
    public static void load(byte[] save, int pos)
    {
        queststarted = save[pos + 1] == 1;
        questcompleted = save[pos + 2] == 1;
        count = save[pos + 3];
    }
    public static void start()
    {
        if (!queststarted)
        {
            queststarted = true;
        }
    }
}
