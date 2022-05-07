using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerShootBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _pistolBulletPrefab;
    [SerializeField] private GameObject _shotgunBulletPrefab;
    [SerializeField] private Transform _playerGunBarrelPoint;

    private PlayerController _playerController;

    public int _shootCount;
    public int _shootPower;

    public bool isPistolActivated;
    public bool isShotgunActivated;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
        InformUI();
    }

    void Update()
    {
        ShootPistol();
        ShootShotgun();
        PlayerAimProcess();
    }

    public void ShootPistol()
    {
        if (isPistolActivated)
        {
            if (Input.GetMouseButtonDown(0))
            {
                var bullet = Instantiate(_pistolBulletPrefab, _playerGunBarrelPoint.transform.position, _playerGunBarrelPoint.transform.rotation);
                bullet.GetComponent<BulletBehaviour>().ActivateBullet(_shootPower);
                _shootCount++;
                Debug.Log(_shootCount);
                InformUI();
            }
        }
    }

    public void ShootShotgun()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isShotgunActivated)
            {
                for (int i = 0; i < 10; i++)
                {
                    var bullet = Instantiate(_shotgunBulletPrefab, _playerGunBarrelPoint.transform.position, _playerGunBarrelPoint.transform.rotation);
                    bullet.transform.rotation *= Quaternion.Euler(Random.Range(-2f,2f), Random.Range(-2f, 2f), 0);
                    bullet.GetComponent<BulletBehaviour>().ActivateBullet(_shootPower);
                    _shootCount++;
                    Debug.Log(_shootCount);
                    InformUI();
                }
            }

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
