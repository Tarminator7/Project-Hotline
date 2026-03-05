using UnityEngine;

public class PlayerTargeting : MonoBehaviour
{
    void Update()
    {
        LookAtMouse();
    }

    private void LookAtMouse()
    {
        Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = (Vector3)(mousePos - new Vector2(transform.position.x, transform.position.y));
    }
}
