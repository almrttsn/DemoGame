using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerController PlayerController;
    public InGamePanel InGamePanel;

    public void Start()
    {
        PlayerController.Initialize(this);
        InGamePanel.Initialize(this);
    }
}
