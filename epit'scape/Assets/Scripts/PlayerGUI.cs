using UnityEngine;
using System.Collections;

public class PlayerGUI : MonoBehaviour {

    public GameObject joueur;
    private int vie;
    public void set_vie(int degats)
    {
        this.vie += degats;
    }

    // Use this for initialization
    void Start()
    {
        this.vie = 100;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider c)
    {
        Debug.Log("contact");
        if (c.tag == "Enemy")
        {
            set_vie(-20);
        }
    }
}