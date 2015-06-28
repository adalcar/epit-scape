using UnityEngine;
using System.Collections;

public class bulletMult : MonoBehaviour {

    public int degats = 50;

    // Use this for initialization
    void Start()
    {
        selfdestruct();
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Enemy")
        {
            Debug.Log("i hit u");
            coll.GetComponent<EnemyHealthZomb>().currentLife -= degats;
        }
        if (coll.tag != "Player")
            Destroy(this.gameObject);
    }
    private IEnumerator selfdestruct()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
