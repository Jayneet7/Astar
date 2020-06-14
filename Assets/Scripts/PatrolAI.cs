using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PatrolAI : MonoBehaviour
{
    public Transform[] patrolpoints;
    int currentpatrolPoint;

    NavMeshAgent nav;

    float currentWaittime;
    float maxWaittime;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

        currentpatrolPoint = -1;

        currentWaittime = 0;
        maxWaittime = 0;

        GotoNext();
    }

    // Update is called once per frame
    void Update()
    {
        if(nav.remainingDistance <0.5f)
        {
            if (maxWaittime == 0)
                maxWaittime = Random.Range(3, 8);

            if (currentWaittime >= maxWaittime)
            {
                maxWaittime = 0;
                currentWaittime = 0;
                GotoNext();
            }

            else
                currentWaittime += Time.deltaTime;
        }
    }

    void GotoNext()
    {
        if(patrolpoints.Length != 0)
        {
            currentpatrolPoint = (currentpatrolPoint + 1) % patrolpoints.Length;
            nav.SetDestination(patrolpoints[currentpatrolPoint].position);
        }
    }
}
