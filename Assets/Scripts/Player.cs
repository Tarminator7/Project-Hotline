using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 400f;
    private Vector2 movement;
    private Vector2 mousePos;
    private Vector2 direction;

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        movement.Normalize();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = movement * Time.fixedDeltaTime * moveSpeed;
    }
}
