using UnityEngine;

public abstract class MovementView : IView
{
    public abstract void OnMove(Vector2 direction);

    public abstract void OnRotate(Vector2 rotatation);

    public abstract void OnJump();

    public abstract void OnCrouch();

    public abstract void OnUncrouch();
}