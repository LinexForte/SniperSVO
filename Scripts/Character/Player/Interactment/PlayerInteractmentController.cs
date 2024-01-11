public class PlayerInteractmentController : InteractmentController
{
    private PlayerInteractmentModel model;
    private InputInterpretator interpretator;

    public PlayerInteractmentController(PlayerInteractmentModel model, InputInterpretator interpretator) : base(model)
    {
        this.model = model;
        this.interpretator = interpretator;
    }

    public override void Update()
    {

    }
}