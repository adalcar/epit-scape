using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
    public float distanceAway;
    public float rangeX;
    public float rangeZ;
    public Transform thisObject;
    public Transform maintarget;
    public Transform target;
    public bool locked = false;
    NavMeshAgent navComponent;

    void Start()
    {
        Vector3 T = new Vector3(Random.value * rangeX, 0, Random.value * rangeZ);
        target.position += T;
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
                float pile = Random.value * 2;
                if(pile > 1)
                    rangeX *= -1;

                float face = Random.value * 2;
                if (face > 1)
                    rangeZ *= -1;

                if (target)
                {
                    NavMeshPath path = new NavMeshPath();

                    if(!navComponent.isPathStale)
                    {
                        if(thisObject.position.x == target.position.x && thisObject.position.z == target.position.z)
                        {
                            target.position = new Vector3(Random.value * rangeX, 0, Random.value * rangeZ);
                        }
                        else
                        {
                            navComponent.SetDestination(target.position);
                        }
                    }
                    else
                    {
                        if(!navComponent.pathPending)
                        {
                            target.position = new Vector3(Random.value * rangeX, 0, Random.value * rangeZ);
                        }
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
                        target.position = new Vector3(Random.value * rangeX, 0, Random.value * rangeZ);
                    }
                }
            }
        }
    }
}
