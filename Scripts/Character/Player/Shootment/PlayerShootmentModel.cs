public class PlayerShootmentModel : ShootmentModel
{
    private PlayerShootmentView view;

    public PlayerShootmentModel(PlayerShootmentView view) : base(view)
    {
        this.view = view;
    }

    public override void OnShoot()
    {
        
    }

    public override void OnReload()
    {
        throw new System.NotImplementedException();
    }

    public override void OnScope()
    {
        throw new System.NotImplementedException();
    }

    public override void OnUnscope()
    {
        throw new System.NotImplementedException();
    }
}