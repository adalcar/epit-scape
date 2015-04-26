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
        Vector3 T = new Vector3(Random.value * 20, 0, Random.value * 20);
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
                float range2 = range;

                float pile = Random.value * 2;
                if(pile > 1)
                    range *= -1;

                float face = Random.value * 2;
                if (face > 1)
                    range2 *= -1;

                if (target)
                {
                    NavMeshPath path = new NavMeshPath();

                    if(NavMesh.CalculatePath(thisObject.position, target.position, 0, path))
                    {
                        if(thisObject.position.x == target.position.x && thisObject.position.z == target.position.z)
                        {
                            target.position = new Vector3(Random.value * range, 0, Random.value * range2);
                        }
                        else
                        {
                            navComponent.SetDestination(target.position);
                        }
                    }
                    else
                    {
                        target.position = new Vector3(Random.value * range, 0, Random.value * range2);
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
                        target.position = new Vector3(Random.value * range, 0, Random.value * range2);
                    }
                }
            }
        }
    }
}
