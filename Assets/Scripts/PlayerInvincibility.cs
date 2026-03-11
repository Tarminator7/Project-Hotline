using UnityEngine;

public class PlayerInvincibility : MonoBehaviour
{
    [SerializeField] private float invincibilityDuration;
    private Invincibility invincibility;

    private void Awake()
    {
        invincibility = GetComponent<Invincibility>();
    }
    public void StartInvincibility()
    {
        invincibility.StartInvincibility(invincibilityDuration);
        Debug.Log("Test 0");
    }
}
