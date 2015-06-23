using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
    public float distanceAway;
    public Transform thisObject;
    public Transform maintarget;
    private Transform target;
    public Transform target0;
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;
    public Transform target5;
    public Transform target6;
    public Transform target7;
    public Transform target8;
    public Transform target9;
    public Transform target10;
    public Transform target11;
    private Transform[] tab;
    public bool locked = false;
    NavMeshAgent navComponent;

    void Start()
    {
        Transform[] truc = { target0, target1, target2, target3, target4, target5, target6, target7, target8, target9, target10, target11 };
        tab = truc;

        int rand = Random.Range(0, 12);
        target = tab[rand];

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
                    NavMeshPath path = new NavMeshPath();

                    if(!navComponent.isPathStale)
                    {
                        if (thisObject.position.x < (target.position.x + 2) && thisObject.position.x > (target.position.x - 2)
                            && thisObject.position.z < (target.position.z + 2) && thisObject.position.z > (target.position.z - 2))
                        {
                            int rand = Random.Range(0, 12);
                            target = tab[rand];
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
                            int rand = Random.Range(0, 12);
                            target = tab[rand];
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
                        int rand = Random.Range(0, 12);
                        target = tab[rand];
                    }
                }
            }
        }
    }
}
