using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigurationPanel : MonoBehaviour
{

    [SerializeField] private Button _pistolButton;
    [SerializeField] private Button _shotgunButton;
    //[SerializeField] private Button _activateRedBulletButton;
    //[SerializeField] private Button _activateWhiteBulletButton;
    //[SerializeField] private Button _activateBigBulletButton;
    //[SerializeField] private Button _activateSmallBulletButton;

    private GameManager _gameManager;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        _pistolButton.enabled = true;
        _shotgunButton.enabled = true;
    }


    void Update()
    {
        
    }

    public void PistolButton()
    {
        _pistolButton.gameObject.SetActive(false);
        _gameManager.PlayerController.PlayerShootBehaviour.isShotgunActivated = false;
        _gameManager.PlayerController.PlayerShootBehaviour.isPistolActivated = true;
        _shotgunButton.gameObject.SetActive(true);
    }
    public void ShotgunButton()
    {
        _shotgunButton.gameObject.SetActive(false);
        _gameManager.PlayerController.PlayerShootBehaviour.isPistolActivated = false;
        _gameManager.PlayerController.PlayerShootBehaviour.isShotgunActivated = true;
        _pistolButton.gameObject.SetActive(true);

    }
}
