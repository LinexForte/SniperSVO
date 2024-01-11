using UnityEngine.Events;

public abstract class InteractmentController : IController
{
    private InteractmentModel model;
    protected event UnityAction Interacted;

    public InteractmentController(InteractmentModel model)
    {
        this.model = model;
        Subscribe();
    }

    public void Subscribe()
    {
        Interacted += model.OnInteract;
    }

    public void Unsubscribe()
    {
        Interacted -= model.OnInteract;
    }

    public abstract void Update();
}