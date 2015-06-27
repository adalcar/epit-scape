using UnityEngine;
using System.Collections;

public class Fin : MonoBehaviour {
    public float tempsWineur = 0f;
    public int winneur = 0;


    void OnGui()
    {
        GUI.Box(new Rect(0, 400, 90, 20), "Gagant" + winneur);
        GUI.Box(new Rect(0, 500, 90, 20), "Temps" + tempsWineur);
    }
    void Start()
    { }
}
