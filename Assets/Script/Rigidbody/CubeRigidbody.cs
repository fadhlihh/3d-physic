using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRigidbody : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rigidbody;
    [SerializeField]
    private Vector3 _torqueMovement;

    private void Start()
    {
        _rigidbody.AddTorque(_torqueMovement);
    }
}
