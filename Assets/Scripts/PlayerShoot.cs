using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private InputActionReference fireActionReference;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private Transform gunOffset;
    [SerializeField] float timeBetweenShots = 0.1f;

    private bool rapidFire;
    private float lastFireTime;

    [SerializeField] private float bulletDespawnTimer = 3.0f;

    private Rigidbody2D rb;

    void Update()
    {
        if (rapidFire)
        {
            float timeSinceLastFire = Time.time - lastFireTime;

            if (timeSinceLastFire >= timeBetweenShots)
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
        GameObject bullet = Instantiate(bulletPrefab, gunOffset.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.linearVelocity = bulletSpeed * transform.up;
        Destroy(bullet.gameObject, bulletDespawnTimer);
    }
}
