using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleCharacterController : MonoBehaviour
{
    [SerializeField]
    private CharacterController _characterControler;
    [SerializeField]
    private float _speed;

    private Vector3 _movement = Vector3.zero;

    private void Update()
    {
        _movement = ReadInput();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Up");
            Jump();
        }
    }

    private void FixedUpdate()
    {
        _characterControler.Move(_movement * _speed * Time.deltaTime);
        AddGravity();
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

    private void AddGravity()
    {
        if (!_characterControler.isGrounded)
        {
            _characterControler.Move(Vector3.down * 2 * Time.deltaTime);
        }
    }

    private void Jump()
    {
        if (_characterControler.isGrounded)
        {
            _characterControler.Move(Vector3.up * 250 * Time.deltaTime);
        }
    }
}
