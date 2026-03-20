using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] WeaponAttributes weaponAttributes;
    [SerializeField] private InputActionReference fireActionReference;
    [SerializeField] private Transform gunOffset;

    private bool rapidFire;
    private float lastFireTime;

    private Rigidbody2D rb;

    void Update()
    {
        if (rapidFire)
        {
            float timeSinceLastFire = Time.time - lastFireTime;

            if (timeSinceLastFire >= weaponAttributes.TimeBetweenShots)
            {
                Shoot();
                lastFireTime = Time.time;
            }
        }
    }

    private void OnEnable()
    {
        fireActionReference.action.Enable();
        fireActionReference.action.started += OnFirePerformed;
        fireActionReference.action.performed += OnFirePerformed;
        fireActionReference.action.canceled += OnFireCancelled;
    }

    private void OnDisable()
    {
        fireActionReference.action.started -= OnFirePerformed;
        fireActionReference.action.performed -= OnFirePerformed;
        fireActionReference.action.canceled -= OnFireCancelled;
        fireActionReference.action.Disable();
    }

    private void OnFirePerformed(InputAction.CallbackContext context)
    {
        rapidFire = true;
    }

    private void OnFireCancelled(InputAction.CallbackContext context)
    {
        rapidFire = false;
    }

    private void Shoot()
    {
        UnityEngine.GameObject bullet = Instantiate(weaponAttributes.BulletPrefab, gunOffset.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.linearVelocity = weaponAttributes.BulletSpeed * transform.up;
        Destroy(bullet.gameObject, weaponAttributes.BulletDespawnTimer);
    }
}
