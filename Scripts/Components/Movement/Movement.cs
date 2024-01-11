public abstract class Movement : IMVC
{
    private MovementController controller;
    private MovementModel model;
    private MovementView view;

    public Movement(MovementController controller, MovementModel model, MovementView view)
    {
        this.controller = controller;
        this.model = model;
        this.view = view;
        Enable();
    }

    public void Enable()
    {
        controller.Subscribe();
        model.Subscribe();
    }

    public void Disable()
    {
        controller.Unsubscribe();
        model.Unsubscribe();
    }

    public void Update()
    {
        controller.Update();
    }
}