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
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * _movementFactor * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * _movementFactor * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.up * _movementFactor * Time.deltaTime;
        }
    }
}
