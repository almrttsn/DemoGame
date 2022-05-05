using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _playerGunBarrelPoint;

    public int _shootPower;

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
        }
    }
}
