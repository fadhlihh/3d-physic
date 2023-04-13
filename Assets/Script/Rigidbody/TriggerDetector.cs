using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Execute when trigger hit another trigger or collider
        Debug.Log("Trigger Enter");
    }

    private void OnTriggerStay(Collider other)
    {
        // Execute when object hit and stay in another trigger or collider
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        // Execute when trigger exit another trigger or collider
        Debug.Log("Trigger Exit");
    }
}
