using System;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _projectilePrefab;
    [SerializeField] 
    private Transform _targetTransform;
    [SerializeField] 
    private Vector3 _targetPosition;
    [SerializeField] 
    private float _targetRadius;
    [SerializeField]
    private float _projectileLength;

    private void Awake()
    {
        _targetPosition = Vector3.up * 2;
        _targetRadius = 1.0f;
        _projectileLength = 1.5f;
    }
    

    public void SpawnThrowableProjectile(Vector3 position)
    {
        Instantiate(_projectilePrefab, position, Quaternion.identity);
    }

    public void SpawnStuckProjectile(float angle)
    {
        GameObject cloneProjectile = Instantiate(_projectilePrefab);

        SetInPinProjectileToTarget(cloneProjectile.transform, angle);
    }

    private void SetInPinProjectileToTarget(Transform projectileTransform, float angle)
    {
        projectileTransform.position =
            Utils.GetPositionFromAngle(_targetRadius + _projectileLength, angle) + _targetPosition;
        projectileTransform.rotation = Quaternion.Euler(0, 0, angle);
        projectileTransform.SetParent((_targetTransform));
        projectileTransform.GetComponent<Pin>().SetInPinProjectileToTarget();
    }
}
