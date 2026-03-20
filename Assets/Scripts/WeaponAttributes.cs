using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "Weapon Attributes", menuName = "Stats/Weapon Attributes")]
public class WeaponAttributes : ScriptableObject
{
    [field: SerializeField] public UnityEngine.GameObject BulletPrefab {  get; private set; }
    [field: SerializeField] public float WeaponDamage { get; private set; }
    [field: SerializeField] public float BulletSpeed { get; private set; }
    [field: SerializeField] public float TimeBetweenShots { get; private set; }
    [field: SerializeField] public float BulletDespawnTimer { get; private set; }
}
