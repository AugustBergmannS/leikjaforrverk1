using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collition : MonoBehaviour
{
    public player_movement movement;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstical") 
        {
            movement.enabled = false;
            GetComponent<player_movement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
