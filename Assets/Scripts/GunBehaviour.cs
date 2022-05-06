using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviour : MonoBehaviour
{
    [SerializeField] private List<GameObject> _buckshots;

    private PlayerController _playerController;
    [SerializeField] private GameObject _buckshotRandomCreationPoint;
    private Vector3 _buckshotRandomCreationOffset;
    private float _randomRangeX;
    private float _randomRangeY;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
    }

    private void Update()
    {
        BuckshotCreationProcess();
    }

    public void BuckshotCreationProcess()
    {
        for(int i = 0; i < _buckshots.Count; i++)
        {
            _buckshotRandomCreationPoint.transform.position = _buckshotRandomCreationOffset;
            _randomRangeX = Random.Range(-0.75f, 1.2f);
            _randomRangeY = Random.Range(-0.75f, 1.2f);
            _buckshotRandomCreationOffset = new Vector3(_randomRangeX, _randomRangeY, 0);
            Debug.Log(_randomRangeY);
            Debug.Log(_buckshotRandomCreationOffset);
            //var _buckshot = Instantiate(_buckshots, _buckshotRandomCreationOffset, Quaternion.identity);
        }
    }


}
