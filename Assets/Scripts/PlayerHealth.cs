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
                Debug.Log("���� ����");
            }
        }
    }

    public void TakeDamage(int damage)
    {
        if (!isInvincible)
        {
            Debug.Log("������: " + damage);
            // ���⿡ ü�� ���� �߰�
        }
        else
        {
            Debug.Log("���� �� - ������ ����");
        }
    }

    public void ActivateInvincibility(float duration)
    {
        isInvincible = true;
        invincibilityTimer = duration;
        Debug.Log("���� ����! " + duration + "��");
    }
}