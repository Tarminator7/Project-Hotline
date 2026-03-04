using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        LookAtMouse();
        rb.linearVelocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
    private void LookAtMouse()
    {
        Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = (Vector3)(mousePos - new Vector2(transform.position.x, transform.position.y));
    }

    // This is testing new mouse control, not working correctly yet
    //private void OnLook(InputValue value)
    //{
    //    Vector2 mousePosition = Camera.main.ScreenToWorldPoint(value.Get<Vector2>());
    //    LookAt(mousePosition);
    //}

    //private void LookAt(Vector3 target)
    //{
    //    float lookAngle = AngleBetweenTwoPoints(transform.position, target) + 90;
    //}

    //private float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    //{
    //    return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    //}
}
