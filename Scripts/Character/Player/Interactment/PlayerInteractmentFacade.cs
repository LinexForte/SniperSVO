public class PlayerInteractmentFacade : InteractmentFacade
{
    private PlayerInteractmentController controller;
    private PlayerInteractmentModel model;
    private PlayerInteractmentView view;
    private PlayerInteractment interactment;

    public PlayerInteractmentFacade(InputInterpretator interpretator)
    {
        view = new PlayerInteractmentView();
        model = new PlayerInteractmentModel(view);
        controller = new PlayerInteractmentController(model, interpretator);
        interactment = new PlayerInteractment(controller, model, view);
    }

    public override void Enable()
    {
        interactment.Enable();
    }

    public override void Disable()
    {
        interactment.Disable();
    }

    public override void Update()
    {
        interactment.Update();
    }
}