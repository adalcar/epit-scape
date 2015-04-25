using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
    public float distanceAway;
    public float range;
    public Transform thisObject;
    public Transform maintarget;
    public Transform target;
    public bool locked = false;
    NavMeshAgent navComponent;

    void Start()
    {
        Vector3 T = new Vector3(Random.value * range, 0, Random.value * range);
        target.position = thisObject.position + T;
        maintarget = GameObject.FindGameObjectWithTag("Player").transform;
        navComponent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(!GetComponent<EnemyHealth>().isDead)
        {
            float dist = Vector3.Distance(maintarget.position, transform.position);

            if(dist < distanceAway)
            {
                locked = true;
            }

            if(locked)
            {
                target = maintarget;

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
            else
            {
                if (target)
                {
                    if(thisObject.position.x == target.position.x && thisObject.position.z == target.position.z)
                    {
                        Vector3 T = new Vector3(Random.value * range, 0, Random.value * range);
                        target.position += T;

                        if(target.position.x > 46 || target.position.x < -46 || target.position.z < 0 || target.position.z > 25)
                        {
                            target.position -= T;
                        }
                    }
                    else
                    {
                        navComponent.SetDestination(target.position);
                    }
                }
                else
                {
                    if (target = null)
                    {
                        target = this.gameObject.GetComponent<Transform>();
                    }
                    else
                    {
                        target.position = new Vector3(Random.value, 0, Random.value);
                    }
                }
            }
        }
    }
}
