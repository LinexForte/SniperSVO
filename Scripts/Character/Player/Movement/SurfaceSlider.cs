using UnityEngine;

public static class SurfaceSlider
{
    public static Vector3 Project(Vector3 direction, SurfaceChecker surfaceChecker)
    {
        Vector3 normal = surfaceChecker.GetSurfaceNormal();
        return direction - Vector3.Dot(direction, normal) * normal;
    }
}