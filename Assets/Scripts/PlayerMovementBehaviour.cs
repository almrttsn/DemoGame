using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField] private int _movementFactor;

    private PlayerController _playerController;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
    }

    private void Update()
    {
        PlayerMovementProcess();
    }

    private void PlayerMovementProcess()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * _movementFactor * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * _movementFactor * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * _movementFactor * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * _movementFactor * Time.deltaTime;
        }
    }
}
