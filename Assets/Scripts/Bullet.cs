using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] WeaponAttributes weaponAttributes;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Enemy>())
        {
            Health health = collision.GetComponent<Health>();
            health.TakeDamage(weaponAttributes.WeaponDamage);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
