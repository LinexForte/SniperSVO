public abstract class Interactment : IMVC
{
    private InteractmentController controller;
    private InteractmentModel model;
    private InteractmentView view;

    public Interactment(InteractmentController controller, InteractmentModel model, InteractmentView view)
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