using System.Collections;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private int _bulletSpeed;

    public void ActivateBullet(int bulletSpeed)
    {
        _bulletSpeed = bulletSpeed;
    }

    private void Update()
    {
        transform.position += transform.forward * _bulletSpeed * Time.deltaTime;
    }
}
