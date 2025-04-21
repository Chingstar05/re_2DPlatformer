using UnityEngine;

public class ViewExpandItem : MonoBehaviour
{
    public float expandedViewSize = 10f;       // 확장된 시야 크기
    public float viewDuration = 5f;            // 유지 시간

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Camera.main.GetComponent<CameraZoom>().ZoomOut(expandedViewSize, viewDuration);
            Destroy(gameObject); // 아이템은 한 번 먹으면 사라짐
        }
    }
}