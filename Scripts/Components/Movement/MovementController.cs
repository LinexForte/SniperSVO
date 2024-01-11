using UnityEngine;
using UnityEngine.Events;

public abstract class MovementController : IController
{
    private MovementModel model;
    private event UnityAction<Vector2> Moved;
    private event UnityAction<Vector2> Rotated;
    private event UnityAction Jumped;
    private event UnityAction Crouched;
    private event UnityAction Uncrouched;

    public MovementController(MovementModel model)
    {
        this.model = model;
        Subscribe();
    }

    public void Subscribe()
    {
        Moved += model.OnMove;
        Rotated += model.OnRotate;
        Jumped += model.OnJump;
        Crouched += model.OnCrouch;
        Uncrouched += model.OnUncrouch;
    }

    public void Unsubscribe()
    {
        Moved -= model.OnMove;
        Rotated -= model.OnRotate;
        Jumped -= model.OnJump;
        Crouched -= model.OnCrouch;
        Uncrouched -= model.OnUncrouch;
    }

    public abstract void Update();

    protected void Direct(Vector2 direction)
    {
        Moved.Invoke(direction);
    }

    protected void Rotate(Vector2 rotation)
    {
        Rotated.Invoke(rotation);
    }

    protected void Jump()
    {
        Jumped.Invoke();
    }

    protected void Crouch()
    {
        Crouched.Invoke();
    }

    protected void Uncrouch()
    {
        Uncrouched.Invoke();
    }
}