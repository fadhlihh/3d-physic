using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRigidbody : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rigidbody;
    [SerializeField]
    private Vector3 _forceMovement;

    private void Start()
    {
        // _rigidbody = GetComponent<Rigidbody>();
        // _rigidbody.AddForce(_forceMovement);
        _rigidbody.velocity = _forceMovement;
    }
}
