using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private InputActionReference fireActionReference;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private Transform gunOffset;
    [SerializeField] float timeBetweenShots;

    [SerializeField] private float bulletDespawnTimer = 1.0f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        fireActionReference.action.Enable();
        fireActionReference.action.performed += OnFirePerformed;
        fireActionReference.action.canceled += OnFireCancelled;
    }

    private void OnDisable()
    {
        fireActionReference.action.performed -= OnFirePerformed;
        fireActionReference.action.canceled -= OnFireCancelled;
        fireActionReference.action.Disable();
    }

    private void OnFirePerformed(InputAction.CallbackContext context)
    {
        Shoot();
    }

    private void OnFireCancelled(InputAction.CallbackContext context)
    {
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, gunOffset.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.linearVelocity = bulletSpeed * transform.up;
        Destroy(bullet.gameObject, bulletDespawnTimer);
    }
}
