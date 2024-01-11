public class PlayerMovement : Movement
{
    private PlayerMovementController controller;
    private PlayerMovementModel model;
    private PlayerMovementView view;

    public PlayerMovement(PlayerMovementController controller, PlayerMovementModel model, PlayerMovementView view) : base(controller, model, view)
    {
        this.controller = controller;
        this.model = model;
        this.view = view;
    }
}