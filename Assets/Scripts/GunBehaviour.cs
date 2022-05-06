using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviour : MonoBehaviour
{
    [SerializeField] private List<GameObject> _buckshots;

    private PlayerController _playerController;
    private Transform _buckshotRandomCreationTransform;
    private float _randomRange;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
        BuckshotCreationProcess();
    }

    public void BuckshotCreationProcess()
    {
        for(int i = 0; i<_buckshots.Count; i++)
        {
            _randomRange = Random.Range(-1f, 1f);
            _buckshotRandomCreationTransform.position = new Vector3(0, _randomRange, 0);
            Debug.Log(_randomRange);
            //var _buckshot = Instantiate(_buckshots, _buckshotRandomCreationTransform.position, Quaternion.identity);
        }
    }


}
