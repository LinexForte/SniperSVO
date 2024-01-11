public class PlayerInteractmentModel : InteractmentModel
{
    private PlayerInteractmentView view;

    public PlayerInteractmentModel(PlayerInteractmentView view) : base(view)
    {
        this.view = view;
    }

    public override void OnInteract()
    {
        throw new System.NotImplementedException();
    }
}