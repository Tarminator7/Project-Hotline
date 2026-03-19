using System.Collections;
using UnityEngine;

public class InvincibilityFlash : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    public IEnumerator FlashCoroutine(float flashDuration, Color flashColor, int numberofFlashes)
    {
        Color startColor = spriteRenderer.color;
        float elapsedFlashTime = 0;
        float elapsedFlashPercentage = 0;
        Debug.Log("Pass 4");

        while (elapsedFlashTime < flashDuration)
        {
            elapsedFlashTime += Time.deltaTime;
            elapsedFlashPercentage = elapsedFlashTime / flashDuration;
            Debug.Log("Pass 5");

            if (elapsedFlashPercentage > 1)
            {
                elapsedFlashPercentage = 1;
                Debug.Log("Pass 6");
            }

            float pingPongPercentage = Mathf.PingPong(elapsedFlashPercentage * 2 * numberofFlashes, 1);
            spriteRenderer.color = Color.Lerp(startColor, flashColor, pingPongPercentage);
            Debug.Log("Pass 7");

            yield return null;
        }
    }
}
