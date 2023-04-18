using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMovement : MonoBehaviour
{
    [SerializeField]
    private Vector3 _offset;
    [SerializeField]
    private Transform _player;
    [SerializeField]
    private float _speed;

    private void Start()
    {
        Vector3 playerPosition = new Vector3(_player.position.x, _player.position.y, transform.position.z) + _offset;
        transform.position = playerPosition;
    }

    private void LateUpdate()
    {
        Vector3 playerPosition = new Vector3(_player.position.x, _player.position.y, transform.position.z) + _offset;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, _speed);
    }
}
