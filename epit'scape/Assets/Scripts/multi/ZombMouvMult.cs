using UnityEngine;
using System.Collections;

public class ZombMouvMult : MonoBehaviour
{
    private Transform maintarget;
    private Transform target1;
    private Transform target2;
    private Transform target3 = null;
    private Transform target4 = null;
    private int nbjoueurs;
    NavMeshAgent navComponent;

    void Start()
    {
        GameObject[] tab = GameObject.FindGameObjectsWithTag("Player");
        nbjoueurs = tab.Length;
        if (nbjoueurs == 2)
        {
            target1 = tab[0].transform;
            target2 = tab[1].transform;
        }
        else if (nbjoueurs == 3)
        {
            target1 = tab[0].transform;
            target2 = tab[1].transform;
            target3 = tab[2].transform;
        }
        else
        {
            target1 = tab[0].transform;
            target2 = tab[1].transform;
            target3 = tab[2].transform;
            target4 = tab[3].transform;
        }

        float dist;
        float distmin = Vector3.Distance(target1.position, this.transform.position);
        maintarget = target1;

        for (int i = 0; i < nbjoueurs; i++)
        {
            dist = Vector3.Distance(tab[i].transform.position, this.transform.position);

            if (dist < distmin)
            {
                distmin = dist;
                maintarget = tab[i].transform;
            }
        }

        navComponent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (!GetComponent<EnemyHealth>().isDead)
        {
            if (maintarget)
            {
                navComponent.SetDestination(maintarget.position);
            }
            else
            {
                if (maintarget = null)
                {
                    maintarget = this.gameObject.GetComponent<Transform>();
                }
                else
                {
                    maintarget = GameObject.FindGameObjectWithTag("Player").transform;
                }
            }
        }
    }
}
