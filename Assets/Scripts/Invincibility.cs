using System.Collections;
using UnityEngine;

public class Invincibility : MonoBehaviour
{
    private Health health;

    private void Awake()
    {
        health = GetComponent<Health>();
    }

    public void StartInvincibility(float duration)
    {
        Debug.Log("Test 1");
        StartCoroutine(InvincibilityCoroutine(duration));
    }

    private IEnumerator InvincibilityCoroutine(float duration)
    {
        health.IsInvincible = true;
        Debug.Log("Test 2");
        yield return new WaitForSeconds(duration);
        health.IsInvincible = false;
    }
}
