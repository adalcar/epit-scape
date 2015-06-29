using UnityEngine;
using System.Collections;

public class enemybullet : MonoBehaviour
{
    public int degats = 100;

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
        Debug.Log("i touched something");
        if (coll.tag == "Player")
        {
            Debug.Log("i touched a player");
            Debug.Log("get hurt biatch");
            coll.GetComponent<playerHealth>().loseLife(degats);

        }
        if(coll.tag != "Enemy")
            Destroy(gameObject);

    }
    private IEnumerator selfdestruct()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }

}
