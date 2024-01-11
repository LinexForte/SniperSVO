using UnityEngine;

public class SurfaceChecker
{
    private CharacterController controller;
    private float maxAngle;
    private float offset = 0.001f;

    public SurfaceChecker(CharacterController controller, float maxAngleOfGround)
    {
        this.controller = controller;
        this.maxAngle = maxAngleOfGround;
    }

    private Vector3 Position => controller.transform.position;

    public bool IsOnGround()
    {
        return Physics.CheckSphere(controller.transform.position + new Vector3(0f, controller.radius - 2 * offset, 0f), controller.radius - offset, 3);
    }

    public Vector3 GetSurfaceNormal()
    {
        RaycastHit hitInfo;
        float minDistance = controller.radius * ((1 / Mathf.Cos(maxAngle * Mathf.Deg2Rad)) - 1) + offset;
        if (Physics.Raycast(Position, Vector3.down, out hitInfo, minDistance))
            return hitInfo.normal;
        else
            return Vector3.up;
    }
}