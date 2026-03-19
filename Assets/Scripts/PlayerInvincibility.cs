using UnityEngine;

public class PlayerInvincibility : MonoBehaviour
{
    [SerializeField] PlayerAttributes playerAttributes;
    private Invincibility invincibility;

    private void Awake()
    {
        invincibility = GetComponent<Invincibility>();
    }
    public void StartInvincibility()
    {
        invincibility.StartInvincibility(playerAttributes.InvincibilityDuration);
        //invincibility.StartInvincibility(playerAttributes.InvincibilityDuration, playerAttributes.FlashColor, playerAttributes.NumberOfFlashes);
    }
}
