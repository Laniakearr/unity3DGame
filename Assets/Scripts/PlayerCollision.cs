using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log (collisionInfo.collider.name + "We hit something.");
        if (collisionInfo.collider.tag == "Obstacles")
        {
            //Debug.Log("We hit the obstacle.");
            movement.enabled = false;
        }
    }
}
