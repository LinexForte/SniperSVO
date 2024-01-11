using UnityEngine;

public class PlayerMovementModel : MovementModel
{
    private PlayerMovementView view;
    private CharacterController characterController;
    private PlayerStats stats;
    private SurfaceChecker surfaceChecker;
    private HandleGravity gravity;
    private Vector2 inputDirectionSmoothed;
    private Transform body;
    private Transform camera;

    private float xRotation;

    public PlayerMovementModel(PlayerMovementView view, CharacterController characterController, PlayerStats stats, Transform body, Transform camera) : base(view)
    {
        this.view = view;
        this.characterController = characterController;
        this.stats = stats;
        this.surfaceChecker = new SurfaceChecker(characterController, stats.MaxAngleOfGround);
        this.gravity = new HandleGravity(characterController, surfaceChecker, stats.Acceleration);
        this.body = body;
        this.camera = camera;
    }

    public override void OnMove(Vector2 inputDirection)
    {
        Vector3 move;
        if (Vector3.Angle(surfaceChecker.GetSurfaceNormal(), Vector3.up) < stats.MaxAngleOfGround)
        {
            inputDirectionSmoothed = Vector2.Lerp(inputDirectionSmoothed, inputDirection, stats.Maneuverability);
            Vector3 direction = (inputDirectionSmoothed.x * body.transform.right + inputDirectionSmoothed.y * body.transform.forward).normalized;
            move = SurfaceSlider.Project(direction, surfaceChecker);
        }
        else
        {
            move = SurfaceSlider.Project(Vector3.down, surfaceChecker);
        }
        characterController.Move(move * stats.Speed * Time.deltaTime);
        gravity.ApplyGravity();
    }

    public override void OnRotate(Vector2 inputRotation)
    {
        xRotation -= inputRotation.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        camera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        body.Rotate(Vector3.up, inputRotation.x);
    }

    public override void OnJump()
    {
        if (surfaceChecker.IsOnGround())
        {
            Vector3 direction = (inputDirectionSmoothed.x * body.transform.right + inputDirectionSmoothed.y * body.transform.forward).normalized;
            Vector3 move = SurfaceSlider.Project(direction, surfaceChecker) + new Vector3(0, stats.JumpPower, 0);
            gravity.ApplyVelocity(move);
        }
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