public class PlayerInteractment : Interactment
{
    private PlayerInteractmentController controller;
    private PlayerInteractmentModel model;
    private PlayerInteractmentView view;

    public PlayerInteractment(PlayerInteractmentController controller, PlayerInteractmentModel model, PlayerInteractmentView view) : base(controller, model, view)
    {
        this.controller = controller;
        this.model = model;
        this.view = view;
    }
}