public class PlayerShootment : Shootment
{
    private PlayerShootmentController controller;
    private PlayerShootmentModel model;
    private PlayerShootmentView view;

    public PlayerShootment(PlayerShootmentController controller, PlayerShootmentModel model, PlayerShootmentView view) : base(controller, model, view)
    {
        this.controller = controller;
        this.model = model;
        this.view = view;
    }
}