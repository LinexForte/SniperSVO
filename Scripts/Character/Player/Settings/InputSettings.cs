using UnityEngine;

[CreateAssetMenu(fileName = "Input", menuName = "ScriptableObject/Settings/Input")]
public class InputSettings : ScriptableObject
{
    [Header("Interactment")]
    [SerializeField] private KeyCode interact;
    [Header("Movement")]
    [SerializeField] private float sensitivity;
    [SerializeField] private KeyCode forward;
    [SerializeField] private KeyCode backward;
    [SerializeField] private KeyCode rightward;
    [SerializeField] private KeyCode leftward;
    [SerializeField] private KeyCode jump;
    [SerializeField] private KeyCode crouch;
    [Header("Shootment")]
    [SerializeField] private KeyCode shoot;
    [SerializeField] private KeyCode scope;
    [SerializeField] private KeyCode reload;
    [SerializeField] private KeyCode nextItem;
    [SerializeField] private KeyCode prevItem;
    [Header("Interface")]
    [SerializeField] private KeyCode escepe;
    [SerializeField] private KeyCode enter;
    [SerializeField] private KeyCode use;

    public KeyCode Interact => interact;
    public float Sensitivity => sensitivity;
    public KeyCode Forward => forward;
    public KeyCode Backward => backward;
    public KeyCode Rightward => rightward;
    public KeyCode Leftward => leftward;
    public KeyCode Jump => jump;
    public KeyCode Crouch => crouch;
    public KeyCode Shoot => shoot;
    public KeyCode Scope => scope;
    public KeyCode Reload => reload;
    public KeyCode NextItem => nextItem;
    public KeyCode PrevItem => prevItem;
    public KeyCode Escepe => escepe;
    public KeyCode Enter => enter;
    public KeyCode Use => use;
}