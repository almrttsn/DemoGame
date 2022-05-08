using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigurationPanel : MonoBehaviour
{

    [SerializeField] private Button _pistolButton;
    [SerializeField] private Button _shotgunButton;
    [SerializeField] private Button _redBulletsButton;
    [SerializeField] private Button _whiteBulletsButton;
    [SerializeField] private Button _bigBulletButton;
    [SerializeField] private Button _smallBulletButton;

    private GameManager _gameManager;

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
        _pistolButton.gameObject.SetActive(false);
        _smallBulletButton.gameObject.SetActive(false);
        _whiteBulletsButton.gameObject.SetActive(false);
    }

    public void ActivatePistol()
    {
        _pistolButton.gameObject.SetActive(false);
        _gameManager.PlayerController.PlayerShootBehaviour.GunType = GunType.Pistol;
        _shotgunButton.gameObject.SetActive(true);
    }
    public void ActivateShotgun()
    {
        _shotgunButton.gameObject.SetActive(false);
        _gameManager.PlayerController.PlayerShootBehaviour.GunType = GunType.Shotgun;
        _pistolButton.gameObject.SetActive(true);
    }

    public void ActivateBigBullets()
    {
        _bigBulletButton.gameObject.SetActive(false);
        _gameManager.PlayerController.PlayerShootBehaviour.BulletSizeType = BulletSizeType.Big;
        _smallBulletButton.gameObject.SetActive(true);
    }

    public void ActivateSmallBullets()
    {
        _smallBulletButton.gameObject.SetActive(false);
        _gameManager.PlayerController.PlayerShootBehaviour.BulletSizeType = BulletSizeType.Small;
        _bigBulletButton.gameObject.SetActive(true);
    }

    public void ActivateRedBullets()
    {
        _redBulletsButton.gameObject.SetActive(false);
        _gameManager.PlayerController.PlayerShootBehaviour.BulletColorType = BulletColorType.Red;
        _whiteBulletsButton.gameObject.SetActive(true);
    }

    public void ActivateWhiteBullets()
    {
        _whiteBulletsButton.gameObject.SetActive(false);
        _gameManager.PlayerController.PlayerShootBehaviour.BulletColorType = BulletColorType.White;
        _redBulletsButton.gameObject.SetActive(true);
    }
}
