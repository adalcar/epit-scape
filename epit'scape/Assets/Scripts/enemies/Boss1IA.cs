using UnityEngine;
using System.Collections;

public class Boss1IA : MonoBehaviour
{
    public Transform thisObject;
    public Transform target;
    NavMeshAgent navComponent;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navComponent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<EnemyHealth>().isDead)
        {
            if (target)
            {
                navComponent.SetDestination(target.position);
            }
            else
            {
                if (target = null)
                {
                    target = this.gameObject.GetComponent<Transform>();
                }
                else
                {
                    target = GameObject.FindGameObjectWithTag("Player").transform;
                }
            }
        }
    }
}
