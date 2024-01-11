using UnityEngine.Events;

public abstract class InteractmentModel : IModel
{
    private InteractmentView view;
    protected event UnityAction Interacted;

    public InteractmentModel(InteractmentView view)
    {
        this.view = view;
        Subscribe();
    }

    public abstract void OnInteract();

    public void Subscribe()
    {
        Interacted += view.OnInteract;
    }

    public void Unsubscribe()
    {
        Interacted -= view.OnInteract;
    }
}