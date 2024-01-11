using UnityEngine;

public class PlayerMovementView : MovementView
{
    private Animator animator;

    public PlayerMovementView(Animator animator) : base()
    {
        this.animator = animator;
    }

    public override void OnMove(Vector2 direction)
    {
        throw new System.NotImplementedException();
    }

    public override void OnRotate(Vector2 rotatation)
    {
        throw new System.NotImplementedException();
    }

    public override void OnJump()
    {
        throw new System.NotImplementedException();
    }

    public override void OnCrouch()
    {
        throw new System.NotImplementedException();
    }

    public override void OnUncrouch()
    {
        throw new System.NotImplementedException();
    }
}