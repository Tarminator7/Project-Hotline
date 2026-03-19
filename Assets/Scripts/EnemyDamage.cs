using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] EnemyAttributes enemyAttributes;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>())
        {
            var health = collision.gameObject.GetComponent<Health>();

            health.TakeDamage(enemyAttributes.EnemyDamageAmount);
        }
    }
}
