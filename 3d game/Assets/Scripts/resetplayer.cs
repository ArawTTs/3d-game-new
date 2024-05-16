using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetplayer : MonoBehaviour
{
    private Vector3 startingPosition;

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reset the player's position to the starting position
            collision.gameObject.transform.position = startingPosition;
        }
    }
}
