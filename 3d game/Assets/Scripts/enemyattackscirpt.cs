using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


public class enemyattackscirpt : MonoBehaviour
{
    public float speed = 5f; 
    public float rotationSpeed = 5f; 
    public float stoppingDistance = 2f; 

    private Transform player; 

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Check if the player is within the stopping distance
         if (Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            // Move the enemy towards the player
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

            // Rotate the enemy to face the player
            Vector3 direction = (player.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
        }
    }

}

