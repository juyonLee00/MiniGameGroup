using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float speed = 50f;
    private Vector3 rotateAxis = Vector3.up;
    void Update()
    {
        transform.Rotate(rotateAxis, speed * Time.deltaTime);
    }
}
