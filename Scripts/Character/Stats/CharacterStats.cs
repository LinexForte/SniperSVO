using UnityEngine;

public abstract class CharacterStats : ScriptableObject
{
    [SerializeField] private float speed;
    public float Speed => speed;
}