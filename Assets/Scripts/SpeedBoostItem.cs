using UnityEngine;

public class SpeedBoostItem : MonoBehaviour
{
    public float boostAmount = 2f;
    public float boostDuration = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.GetComponent<PlayerController>();
            if (player != null)
            {
                player.ActivateSpeedBoost(boostAmount, boostDuration);
            }

            Destroy(gameObject); // 아이템 사라짐
        }
    }
}