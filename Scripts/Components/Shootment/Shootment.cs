public abstract class Shootment : IMVC
{
    private ShootmentController controller;
    private ShootmentModel model;
    private ShootmentView view;

    public Shootment(ShootmentController controller, ShootmentModel model, ShootmentView view)
    {
        this.controller = controller;
        this.model = model;
        this.view = view;
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