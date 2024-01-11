using UnityEngine;

public class Player : Character
{
    [SerializeField] private InputSettings inputSettings;
    [SerializeField] private PlayerStats stats;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Animator animator;
    [SerializeField] private Transform body;
    [SerializeField] private Transform torso;
    private IMVCFacade interactment;
    private IMVCFacade movement;
    private IMVCFacade shootment;
    private InputInterpretator interpretator;

    private void OnEnable()
    {
        interpretator = new KeyboardInputInterpretator(inputSettings);
        interactment = new PlayerInteractmentFacade(interpretator);
        movement = new PlayerMovementFacade(interpretator, inputSettings, characterController, stats, animator, body, torso);
        shootment = new PlayerShootmentFacade(interpretator);
        Initalize(interactment, movement, shootment);
    }

    private void Update()
    {
        interactment.Update();
        movement.Update();
        shootment.Update();
    }
}