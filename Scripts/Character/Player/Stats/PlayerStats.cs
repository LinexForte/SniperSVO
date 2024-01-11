using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "ScriptableObject/Stats/Player")]
public class PlayerStats : CharacterStats
{
    [SerializeField] private float maneuverability;
    [SerializeField] private float maxAngleOfGround;
    [SerializeField] private float jumpHeigh;
    [Header("Physics")]
    [SerializeField] private Vector3 acceleration;

    public float Maneuverability => maneuverability;
    public float MaxAngleOfGround => maxAngleOfGround;
    public float JumpPower => Mathf.Sqrt(2 * acceleration.magnitude * jumpHeigh);
    public Vector3 Acceleration => acceleration;
}