using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager GameManager;
    public PlayerShootBehaviour PlayerShootBehaviour;
    public PlayerMovementBehaviour PlayerMovementBehaviour;
    public GunBehaviour GunBehaviour;

    public void Initialize(GameManager gameManager)
    {
        PlayerMovementBehaviour.Initialize(this);
        PlayerShootBehaviour.Initialize(this);
        GunBehaviour.Initialize(this);
    }
}
