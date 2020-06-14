using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemy_speed;
    public float stopdistance;
    public float retreatdistance;



    public Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector2.Distance(transform.position, player.position)) > stopdistance)

        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, enemy_speed * Time.deltaTime);
        }
        else if ((Vector2.Distance(transform.position, player.position)) < stopdistance && (Vector2.Distance(transform.position, player.position)) > retreatdistance)
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, player.position) < retreatdistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -enemy_speed * Time.deltaTime);
        }
    }
}

