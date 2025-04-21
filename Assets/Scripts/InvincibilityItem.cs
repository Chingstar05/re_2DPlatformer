using UnityEngine;

public class InvincibilityItem : MonoBehaviour
{
    public float invincibilityDuration = 5f; // 무적 지속 시간 (초)

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.ActivateInvincibility(invincibilityDuration);
            }

            Destroy(gameObject); // 아이템을 먹으면 사라지게
        }
    }
}