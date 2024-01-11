using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private IMVCFacade interactment;
    private IMVCFacade movement;
    private IMVCFacade shootment;

    protected void Initalize(IMVCFacade interactment, IMVCFacade movement, IMVCFacade shootment)
    {
        this.interactment = interactment;
        this.movement = movement;
        this.shootment = shootment;
    }
}