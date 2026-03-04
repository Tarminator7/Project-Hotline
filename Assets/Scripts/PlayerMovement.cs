using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject bulletPrefab;
[SerializeField] private Transform firePoint;
[SerializeField] private float fireRate = 0.2f;

private float fireTimer;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    
    {
        fireTimer -= Time.deltaTime;

if (Input.GetMouseButton(0) && fireTimer <= 0)
{
    Shoot();
    fireTimer = fireRate;
}
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    mousePos.z = 0f;

    Vector2 direction = mousePos - transform.position;
    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;

    transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement.normalized * speed;
    }
    void Shoot()
{
    Instantiate(bulletPrefab, firePoint.position, transform.rotation);
}
    
}