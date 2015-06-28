using UnityEngine;
using System.Collections;
using Assets.Scripts.display;
public class Keyboardquestportal : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("col");
            if (KeyboardQuest.questcompleted)
            {
                Debug.Log("sucess");
                enter();
            }
            else display.infodisplay("closedDoor");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    void enter()
    {
        Application.LoadLevel("Etage2 bis");
    }
}