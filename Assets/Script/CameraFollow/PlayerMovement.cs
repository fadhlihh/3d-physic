using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _jumpForce;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 movement = GetJumpInput();
        _rigidbody.AddForce(movement * _jumpForce);
    }

    private void FixedUpdate()
    {
        Vector3 movement = GetMovementInput();
        _rigidbody.AddForce(movement * _speed);
    }

    private Vector3 GetMovementInput()
    {
        Vector3 axisInput = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        return axisInput;
    }

    private Vector3 GetJumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            return Vector3.up;
        }
        return Vector3.zero;
    }
}
