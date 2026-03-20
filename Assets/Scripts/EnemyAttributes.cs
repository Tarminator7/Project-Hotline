using UnityEngine;

[CreateAssetMenu(fileName = "Enemy Attributes", menuName = "Stats/Enemy Attributes")]
public class EnemyAttributes : ScriptableObject
{
    [field: SerializeField] public float Speed { get; private set; }
    [field: SerializeField] public float RotationSpeed { get; private set; }
    [field: SerializeField] public float PlayerAwarenessDistance { get; private set; }
    [field: SerializeField] public float EnemyDamageAmount { get; private set; }
    [field: SerializeField] public float ObstacleCheckCircleRadius { get; private set; }
    [field: SerializeField] public float ObstacleCheckDistance { get; private set; }
    [field: SerializeField] public LayerMask ObstacleLayerMask { get; private set; }
}
