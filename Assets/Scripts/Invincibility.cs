using System.Collections;
using UnityEngine;

public class Invincibility : MonoBehaviour
{
    private Health health;
    private InvincibilityFlash invincibilityFlash;

    private void Awake()
    {
        health = GetComponent<Health>();
        invincibilityFlash = GetComponent<InvincibilityFlash>();
    }

    public void StartInvincibility(float duration)
    {
        StartCoroutine(InvincibilityCoroutine(duration));
    }

    private IEnumerator InvincibilityCoroutine(float duration)
    {
        health.IsInvincible = true;
        yield return new WaitForSeconds(duration);
        health.IsInvincible = false;
    }

    //public void StartInvincibility(float duration, Color flashColor, int numberOfFlashes)
    //{
    //    StartCoroutine(InvincibilityCoroutine(duration, flashColor, numberOfFlashes));
    //}

    //private IEnumerator InvincibilityCoroutine(float duration, Color flashColor, int numberOfFlashes)
    //{
    //    Debug.Log("Pass 3");
    //    health.IsInvincible = true;
    //    yield return invincibilityFlash.FlashCoroutine(duration, flashColor, numberOfFlashes);
    //    health.IsInvincible = false;
    //    Debug.Log("Pass 9");
    //}
}
