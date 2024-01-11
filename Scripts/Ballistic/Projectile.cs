using UnityEngine;

public class Projectile : MonoBehaviour
{
    private ProjectileModel model;
    [SerializeField] private Bullet bulletData;
    [SerializeField] private Environment environment;

    private void Update()
    {
        transform.position = model.GetPosition();
    }
}