using UnityEngine.Events;

public abstract class ShootmentController : IController
{
    private ShootmentModel model;
    private event UnityAction Shooted;
    private event UnityAction Reloaded;
    private event UnityAction Scoped;
    private event UnityAction Unscoped;

    public ShootmentController(ShootmentModel model)
    {
        this.model = model;
    }

    public void Subscribe()
    {
        Shooted += model.OnShoot;
        Reloaded += model.OnReload;
        Scoped += model.OnScope;
        Unscoped += model.OnUnscope;
    }

    public void Unsubscribe()
    {
        Shooted -= model.OnShoot;
        Reloaded -= model.OnReload;
        Scoped -= model.OnScope;
        Unscoped -= model.OnUnscope;
    }

    public abstract void Update();

    protected void Shoot()
    {
        Shooted.Invoke();
    }

    protected void Reload()
    {
        Reloaded.Invoke();
    }

    protected void Scope()
    {
        Scoped.Invoke();
    }

    protected void Unscope()
    {
        Unscoped.Invoke();
    }
}