using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField] 
    private GameObject _pillar;

    public void SetInPinProjectileToTarget()
    {
        _pillar.SetActive(true);
    }
}
