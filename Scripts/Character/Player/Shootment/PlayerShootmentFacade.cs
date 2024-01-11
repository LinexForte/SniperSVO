public class PlayerShootmentFacade : ShootmentFacade
{
    private PlayerShootmentController controller;
    private PlayerShootmentModel model;
    private PlayerShootmentView view;
    private PlayerShootment shootment;

    public PlayerShootmentFacade(InputInterpretator interpretator)
    {
        view = new PlayerShootmentView();
        model = new PlayerShootmentModel(view);
        controller = new PlayerShootmentController(model, interpretator);
        shootment = new PlayerShootment(controller, model, view);
    }

    public override void Enable()
    {
        shootment.Enable();
    }

    public override void Disable()
    {
        shootment.Disable();
    }

    public override void Update()
    {
        shootment.Update();
    }
}