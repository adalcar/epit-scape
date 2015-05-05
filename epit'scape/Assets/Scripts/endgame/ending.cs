using UnityEngine;
using System.Collections;
using Assets.Scripts;
public class ending : MonoBehaviour {
    public void Giveup()
    {
        Application.LoadLevel("MainMenu");
    }
    public void restart()
    {
        Application.LoadLevel(playerdata.scene);
    }
}
