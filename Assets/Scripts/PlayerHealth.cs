using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private bool isInvincible = false;
    private float invincibilityTimer = 5f;

    void Update()
    {
        if (isInvincible)
        {
            invincibilityTimer -= Time.deltaTime;
            if (invincibilityTimer <= 0f)
            {
                isInvincible = false;
                Debug.Log("무적 종료");
            }
        }
    }

    public void TakeDamage(int damage)
    {
        if (!isInvincible)
        {
            Debug.Log("데미지: " + damage);
            // 여기에 체력 감소 추가
        }
        else
        {
            Debug.Log("무적 중 - 데미지 무시");
        }
    }

    public void ActivateInvincibility(float duration)
    {
        isInvincible = true;
        invincibilityTimer = duration;
        Debug.Log("무적 시작! " + duration + "초");
    }
}