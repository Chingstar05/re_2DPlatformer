using UnityEngine;

public class ViewExpandItem : MonoBehaviour
{
    public float expandedViewSize = 10f;       // Ȯ��� �þ� ũ��
    public float viewDuration = 5f;            // ���� �ð�

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Camera.main.GetComponent<CameraZoom>().ZoomOut(expandedViewSize, viewDuration);
            Destroy(gameObject); // �������� �� �� ������ �����
        }
    }
}