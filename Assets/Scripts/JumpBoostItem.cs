using UnityEngine;

public class JumpBoostItem : MonoBehaviour
{
    public float jumpMultiplier = 2f;
    public float boostDuration = 5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.ActivateJumpBoost(jumpMultiplier, boostDuration);
                Destroy(gameObject);
            }
        }
    }
}