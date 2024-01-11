using UnityEngine;

public class ProjectileModel
{
    private Bullet stats;
    private Environment environment;
    private Vector3 position;
    private Vector3 velocity;
    private Vector3 acceleration;

    public ProjectileModel(Vector3 startPosition, Vector3 startVelocity, Bullet stats, Environment environment)
    {
        position = startPosition;
        velocity = startVelocity;
        this.stats = stats;
        this.environment = environment;
    }

    public void Update()
    {
        acceleration = new Vector3();
    }

    public Vector3 GetPosition()
    {
        return position;
    }

    private float G(float V)
    {
        return (0.2002f * V - 48.05f * Mathf.Sqrt((0.1648f * V - 47.95f) * (0.1648f * V - 47.95f) + 9.6f) + (0.0442f * V * (V - 300)) / 371 + Mathf.Pow(V / 200, 10)) / V;
    }
}