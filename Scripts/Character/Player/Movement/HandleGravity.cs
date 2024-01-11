using UnityEngine;

public class HandleGravity
{
    private CharacterController controller;
    private SurfaceChecker surfaceChecker;
    private readonly Vector3 acceleration;
    private Vector3 velocity;

    public HandleGravity(CharacterController controller, SurfaceChecker surfaceChecker, Vector3 acceleration)
    {
        this.controller = controller;
        this.surfaceChecker = surfaceChecker;
        this.acceleration = acceleration;
    }

    public void ApplyGravity()
    {
        if (!surfaceChecker.IsOnGround())
        {
            velocity += 0.5f * acceleration * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
        else
        {
            velocity = Vector3.zero;
        }
    }

    public void ApplyVelocity(Vector3 velocity)
    {
        this.velocity += velocity;
        controller.Move(this.velocity * Time.deltaTime);
    }
}