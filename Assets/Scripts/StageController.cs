using System;
using UnityEngine;

public class StageController : MonoBehaviour
{
    [SerializeField] 
    private ProjectileSpawner _projectileSpawner;
    [SerializeField]
    private int _throwableProjectileCount;
    [SerializeField]
    private int _stuckProjectileCount;
    [SerializeField] 
    private int[] _stuckProjectileAngles;

    private Vector3 _firstProjectilePosition;

    public float throwablePinDistance { private set; get; } = 1;

    private void Awake()
    {
        _stuckProjectileCount = -1;
        _firstProjectilePosition = Vector3.down * 2;
        
        for (int i = 0; i < _throwableProjectileCount; i++)
        {
            _projectileSpawner.SpawnThrowableProjectile(_firstProjectilePosition + Vector3.down * throwablePinDistance * i);
        }

        if (_stuckProjectileCount != -1)
        {
            for (int i = 0; i < _stuckProjectileCount; i++)
            {
                float angle = (360 / _stuckProjectileCount) * i;
                _projectileSpawner.SpawnStuckProjectile(angle);
            }
        }

        else
        {
            for (int i = 0; i < _stuckProjectileAngles.Length; i++)
            {
                _projectileSpawner.SpawnStuckProjectile(_stuckProjectileAngles[i]);
            }
        }
        
    }
}
