using UnityEngine.Events;

public abstract class ShootmentModel : IModel
{
    private ShootmentView view;
    private event UnityAction Shooted;
    private event UnityAction Reloaded;
    private event UnityAction Scoped;
    private event UnityAction Unscoped;

    public ShootmentModel(ShootmentView view)
    {
        this.view = view;
    }

    public abstract void OnShoot();
    public abstract void OnReload();
    public abstract void OnScope();
    public abstract void OnUnscope();

    public void Subscribe()
    {
        Shooted += view.OnShoot;
        Reloaded += view.OnReload;
        Scoped += view.OnScope;
        Unscoped += view.OnUnscope;
    }

    public void Unsubscribe()
    {
        Shooted -= view.OnShoot;
        Reloaded -= view.OnReload;
        Scoped -= view.OnScope;
        Unscoped -= view.OnUnscope;
    }
}