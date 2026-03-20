using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "Player Attributes", menuName = "Stats/Player Attributes")]
public class PlayerAttributes : ScriptableObject
{
    [field: SerializeField] public float MovementSpeed { get; private set; }
    [field: SerializeField] public float InvincibilityDuration { get; private set; }
    [field :SerializeField] public Color FlashColor { get; private set; }
    [field: SerializeField] public int NumberOfFlashes {  get; private set; }
}
