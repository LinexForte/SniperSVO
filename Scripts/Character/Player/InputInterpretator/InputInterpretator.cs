using UnityEngine;
using UnityEngine.Events;

public abstract class InputInterpretator
{
    public abstract bool IsInteractKeyHold();

    public abstract bool IsInteractKeyDown();

    public abstract bool IsInteractKeyUp();

    public abstract Vector2 GetMoveInputDirection();

    public abstract Vector2 GetRotateInputDelta();

    public abstract bool IsJumpKeyHold();

    public abstract bool IsJumpKeyDown();

    public abstract bool IsJumpKeyUp();

    public abstract bool IsCrouchKeyHold();

    public abstract bool IsCrouchKeyDown();

    public abstract bool IsCrouchKeyUp();

    public abstract bool IsShootKeyHold();

    public abstract bool IsShootKeyDown();

    public abstract bool IsShootKeyUp();

    public abstract bool IsScopeKeyHold();

    public abstract bool IsScopeKeyUp();

    public abstract bool IsScopeKeyDown();

    public abstract bool IsReloadKeyHold();

    public abstract bool IsReloadKeyDown();

    public abstract bool IsReloadKeyUp();
}