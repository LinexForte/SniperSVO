public class PlayerShootmentController : ShootmentController
{
    private PlayerShootmentModel model;
    private InputInterpretator interpretator;

    public PlayerShootmentController(PlayerShootmentModel model, InputInterpretator interpretator) : base(model)
    {
        this.model = model;
        this.interpretator = interpretator;
    }

    public override void Update()
    {
        if (interpretator.IsShootKeyDown()) Shoot();
        if (interpretator.IsReloadKeyDown()) Reload();
        if (interpretator.IsScopeKeyDown()) Scope();
        if (interpretator.IsScopeKeyUp()) Unscope();
    }
}