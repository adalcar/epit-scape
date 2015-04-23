using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
    public float deathDistance = 0.5f;
    public float distanceAway;
    public Transform thisObject;
    public Transform target;
    NavMeshAgent navComponent;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navComponent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(!GetComponent<EnemyHealth>().isDead)
        {
            float dist = Vector3.Distance(target.position, transform.position);

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
