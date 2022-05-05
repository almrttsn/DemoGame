using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _playerGunBarrelPoint;

    private PlayerController _playerController;

    public int _shootCount;
    public int _shootPower;


    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
        InformUI();
    }

    void Update()
    {
        PlayerPullTriggerProcess();
    }

    private void PlayerPullTriggerProcess()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(_bullet, _playerGunBarrelPoint.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(_playerGunBarrelPoint.transform.forward * _shootPower);
            _shootCount++;
            Debug.Log(_shootCount);
            InformUI();
        }
    }

    private void InformUI()
    {
        _playerController.GameManager.InGamePanel.PopulateShootCountText(_shootCount);
    }
}
