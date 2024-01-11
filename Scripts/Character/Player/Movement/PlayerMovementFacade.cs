using UnityEngine;

public class PlayerMovementFacade : MovementFacade
{
    private PlayerMovementController controller;
    private PlayerMovementModel model;
    private PlayerMovementView view;
    private PlayerMovement movement;

    public PlayerMovementFacade(InputInterpretator interpretator, InputSettings inputSettings, CharacterController characterController, PlayerStats stats, Animator animator, Transform body, Transform torso)
    {
        view = new PlayerMovementView(animator);
        model = new PlayerMovementModel(view, characterController, stats, body, torso);
        controller = new PlayerMovementController(model, interpretator, inputSettings);
        movement = new PlayerMovement(controller, model, view);
    }

    public override void Enable()
    {
        movement.Enable();
    }

    public override void Disable()
    {
        movement.Disable();
    }

    public override void Update()
    {
        movement.Update();
    }
}