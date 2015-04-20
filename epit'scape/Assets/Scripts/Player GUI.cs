using UnityEngine;
using System.Collections;

public class PlayerGUI : MonoBehaviour {

    public GameObject joueur;
    private int vie = 100;
    public void set_vie(int degats)
    {
        this.vie += degats;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (this.vie < 0)
        {
            Destroy(this.gameObject);
        }
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