using UnityEngine;

[CreateAssetMenu(fileName = "Environment", menuName = "ScriptableObject/Ballistic/Environment")]
public class Environment : ScriptableObject
{
    [SerializeField] private Vector3 wind;
    [SerializeField] private Vector3 _g;
    [SerializeField] private const float P0n = 1.206f;

    public Vector3 W => wind;
    public Vector3 g => _g;
}