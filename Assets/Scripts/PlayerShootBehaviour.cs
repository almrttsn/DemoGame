using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public enum GunType
{
    Pistol,Shotgun
}

public enum BulletSizeType
{
    Small,Big
}

public enum BulletColorType
{
    White,Red
}

public class PlayerShootBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _whiteBulletPrefab;
    [SerializeField] private GameObject _redBulletPrefab;

    [SerializeField] private Transform _playerGunBarrelPoint;

    private PlayerController _playerController;

    public int _shootCount;
    public int _shootPower;

    public GunType GunType;
    public BulletSizeType BulletSizeType;
    public BulletColorType BulletColorType;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
        InformUI();
    }

    void Update()
    {
        PlayerAimProcess();

        if (Input.GetMouseButtonDown(0))
        {
            switch (GunType)
            {
                case GunType.Pistol:
                    ShootPistol();
                    break;
                case GunType.Shotgun:
                    ShootShotgun();
                    break;
                default:
                    break;
            }
        }        
    }

    public void ShootPistol()
    {
        GameObject bullet = null;
        if (BulletColorType == BulletColorType.Red)
        {
            bullet = Instantiate(_redBulletPrefab, _playerGunBarrelPoint.transform.position, _playerGunBarrelPoint.transform.rotation);
        }
        else
        {
            bullet = Instantiate(_whiteBulletPrefab, _playerGunBarrelPoint.transform.position, _playerGunBarrelPoint.transform.rotation);
        }
        if (BulletSizeType == BulletSizeType.Big)
        {
            bullet.transform.localScale *= 10f;
        }
        bullet.GetComponent<BulletBehaviour>().ActivateBullet(_shootPower);
        _shootCount++;
        Debug.Log(_shootCount);
        InformUI();
    }

    public void ShootShotgun()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject bullet = null;
            if(BulletColorType == BulletColorType.Red)
            {
                bullet = Instantiate(_redBulletPrefab, _playerGunBarrelPoint.transform.position, _playerGunBarrelPoint.transform.rotation);
            }
            else
            {
                bullet = Instantiate(_whiteBulletPrefab, _playerGunBarrelPoint.transform.position, _playerGunBarrelPoint.transform.rotation);
            }
            if (BulletSizeType == BulletSizeType.Big)
            {
                bullet.transform.localScale *= 10f;
            }
            bullet.transform.rotation *= Quaternion.Euler(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0);
            bullet.GetComponent<BulletBehaviour>().ActivateBullet(_shootPower);
            _shootCount++;
            Debug.Log(_shootCount);
            InformUI();
        }
    }
    private void PlayerAimProcess()
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
    }

    private void InformUI()
    {
        _playerController.GameManager.InGamePanel.PopulateShootCountText(_shootCount);
    }
}
