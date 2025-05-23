using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _projectilePrefab;

    public void SpawnThrowableProjectile(Vector3 position)
    {
        Instantiate(_projectilePrefab, position, Quaternion.identity);
    }
}
