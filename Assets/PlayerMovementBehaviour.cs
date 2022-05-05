using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{

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
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += -transform.right;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += transform.right;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = -transform.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = transform.up;
        }
    }
}
