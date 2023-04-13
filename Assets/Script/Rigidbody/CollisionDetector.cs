using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        // Execute when collider hit another collider
        Debug.Log("Collision Enter");
    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        // Execute when collider hit and stay in another collider
        Debug.Log("Collision Stay");
    }

    private void OnCollisionExit(Collision collisionInfo)
    {
        // Execute when collider exit another collider
        Debug.Log("Collision Exit");
    }
}
