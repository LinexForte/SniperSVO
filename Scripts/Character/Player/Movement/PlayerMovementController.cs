using UnityEngine;

public class PlayerMovementController : MovementController
{
    private PlayerMovementModel model;
    private InputInterpretator interpretator;
    private InputSettings inputSettings;

    public PlayerMovementController(PlayerMovementModel model, InputInterpretator interpretator, InputSettings inputSettings) : base(model)
    {
        this.model = model;
        this.interpretator = interpretator;
        this.inputSettings = inputSettings;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public override void Update()
    {
        Direct(interpretator.GetMoveInputDirection());
        Rotate(interpretator.GetRotateInputDelta() * inputSettings.Sensitivity);
        if (interpretator.IsJumpKeyDown()) Jump();
        if (interpretator.IsCrouchKeyDown()) Crouch();
        if (interpretator.IsCrouchKeyUp()) Uncrouch();
    }
}