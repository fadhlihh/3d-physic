using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Rigidbody _rigidbody;

    private Vector3 _movement = Vector3.zero;

    private void Update()
    {
        _movement = ReadInput();
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(_movement * _speed);
    }

    private Vector3 ReadInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            return Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            return Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            return Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            return Vector3.right;
        }
        return Vector3.zero;
    }
}
