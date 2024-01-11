using UnityEngine;
using UnityEngine.Events;

public abstract class MovementModel : IModel
{
    private MovementView view;
    private event UnityAction<Vector2> Moved;
    private event UnityAction<Vector2> Rotated;
    private event UnityAction Jumped;
    private event UnityAction Crouched;
    private event UnityAction Uncrouched;

    public MovementModel(MovementView view)
    {
        this.view = view;
        Subscribe();
    }

    public abstract void OnMove(Vector2 direction);

    public abstract void OnRotate(Vector2 rotatation);

    public abstract void OnJump();

    public abstract void OnCrouch();

    public abstract void OnUncrouch();

    public void Subscribe()
    {
        Moved += view.OnMove;
        Rotated += view.OnRotate;
        Jumped += view.OnJump;
        Crouched += view.OnCrouch;
        Uncrouched += view.OnUncrouch;
    }

    public void Unsubscribe()
    {
        Moved -= view.OnMove;
        Rotated -= view.OnRotate;
        Jumped -= view.OnJump;
        Crouched -= view.OnCrouch;
        Uncrouched -= view.OnUncrouch;
    }


    protected void ChangeDirection(Vector2 direction)
    {
        Moved.Invoke(direction);
    }

    protected void ChangeRotation(Vector2 rotation)
    {
        Rotated.Invoke(rotation);
    }

    protected void DoJump()
    {
        Jumped.Invoke();
    }

    protected void DoCrouch()
    {
        Crouched.Invoke();
    }

    protected void DoUncrouch()
    {
        Uncrouched.Invoke();
    }
}