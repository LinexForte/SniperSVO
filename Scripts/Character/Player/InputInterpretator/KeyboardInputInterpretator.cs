using UnityEngine;

public class KeyboardInputInterpretator : InputInterpretator
{
    private InputSettings settings;

    public KeyboardInputInterpretator(InputSettings settings)
    {
        this.settings = settings;
    }

    public override bool IsInteractKeyHold()
    {
        return Input.GetKey(settings.Interact);
    }

    public override bool IsInteractKeyDown()
    {
        return Input.GetKeyDown(settings.Interact);
    }

    public override bool IsInteractKeyUp()
    {
        return Input.GetKeyUp(settings.Interact);
    }

    public override Vector2 GetMoveInputDirection()
    {
        Vector2 direction = Vector2.zero;
        if (Input.GetKey(settings.Forward)) direction += Vector2.up;
        if (Input.GetKey(settings.Backward)) direction += Vector2.down;
        if (Input.GetKey(settings.Rightward)) direction += Vector2.right;
        if (Input.GetKey(settings.Leftward)) direction += Vector2.left;
        return direction;
    }

    public override Vector2 GetRotateInputDelta()
    {
        return new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
    }

    public override bool IsJumpKeyHold()
    {
        return Input.GetKey(settings.Jump);
    }

    public override bool IsJumpKeyDown()
    {
        return Input.GetKeyDown(settings.Jump);
    }

    public override bool IsJumpKeyUp()
    {
        return Input.GetKeyUp(settings.Jump);
    }

    public override bool IsCrouchKeyHold()
    {
        return Input.GetKey(settings.Crouch);
    }

    public override bool IsCrouchKeyDown()
    {
        return Input.GetKeyDown(settings.Crouch);
    }

    public override bool IsCrouchKeyUp()
    {
        return Input.GetKeyUp(settings.Crouch);
    }

    public override bool IsShootKeyHold()
    {
        return Input.GetKey(settings.Shoot);
    }

    public override bool IsShootKeyDown()
    {
        return Input.GetKeyDown(settings.Shoot);
    }

    public override bool IsShootKeyUp()
    {
        return Input.GetKeyUp(settings.Shoot);
    }

    public override bool IsScopeKeyHold()
    {
        return Input.GetKey(settings.Scope);
    }

    public override bool IsScopeKeyDown()
    {
        return Input.GetKeyDown(settings.Scope);
    }

    public override bool IsScopeKeyUp()
    {
        return Input.GetKeyUp(settings.Scope);
    }

    public override bool IsReloadKeyHold()
    {
        return Input.GetKey(settings.Reload);
    }

    public override bool IsReloadKeyDown()
    {
        return Input.GetKeyDown(settings.Reload);
    }

    public override bool IsReloadKeyUp()
    {
        return Input.GetKeyUp(settings.Reload);
    }
}