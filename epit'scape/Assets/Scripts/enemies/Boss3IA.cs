using UnityEngine;
using System.Collections;

public class Boss3IA : MonoBehaviour
{
    public Transform thisObject;
    public Transform maintarget;
    NavMeshAgent navComponent;
    private Transform target;
    public Transform target0;
    public Transform target1;
    public Transform target2;
    public Transform target3;
    private Transform[] tab;

	// Use this for initialization
	void Start ()
    {
        Transform[] truc = { target0, target1, target2, target3 };
        tab = truc;

        int rand = Random.Range(0, 4);
        target = tab[rand];

        maintarget = GameObject.FindGameObjectWithTag("Player").transform;
        navComponent = this.gameObject.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(!GetComponent<EnemyHealth>().isDead)
        {
            if(!EnemyAttack.attacked)
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
                if(target == maintarget)
                {
                    int rand = Random.Range(0, 4);
                    target = tab[rand];
                }
                else
                {
                    NavMeshPath path = new NavMeshPath();

                    if (!navComponent.isPathStale)
                    {
                        if (thisObject.position.x < (target.position.x + 2) && thisObject.position.x > (target.position.x - 2)
                            && thisObject.position.z < (target.position.z + 2) && thisObject.position.z > (target.position.z - 2))
                        {
                            EnemyAttack.attacked = false;
                            target = maintarget;
                        }
                        else
                        {
                            navComponent.SetDestination(target.position);
                        }
                    }
                    else
                    {
                        if (!navComponent.pathPending)
                        {
                            int rand = Random.Range(0, 4);
                            target = tab[rand];
                        }
                    }
                }
            }
        }
	}
}
