using Unity.VisualScripting;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private float damageAmount;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>())
        {
            var health = collision.gameObject.GetComponent<Health>();

            health.TakeDamage(damageAmount);
        }
    }
}
