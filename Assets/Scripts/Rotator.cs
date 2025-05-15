using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float _rotationSpeed = 50f;
    private Vector3 _rotationAxis = Vector3.up;
    void Update()
    {
        transform.Rotate(_rotationAxis, _rotationSpeed * Time.deltaTime);
    }
}
