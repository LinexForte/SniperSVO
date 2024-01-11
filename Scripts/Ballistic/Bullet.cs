using UnityEngine;

[CreateAssetMenu(fileName = "BulletStats", menuName = "ScriptableObject/Ballistic/Bullet")]
public class Bullet : ScriptableObject
{
    [SerializeField] private float c;
    [SerializeField] private float v0;

    public float C => c;
    public float V0 => v0;
}