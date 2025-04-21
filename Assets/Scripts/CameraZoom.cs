using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private float originalSize;
    private bool isZoomedOut = false;

    private void Start()
    {
        originalSize = Camera.main.orthographicSize;
    }

    public void ZoomOut(float newSize, float duration)
    {
        if (!isZoomedOut)
        {
            isZoomedOut = true;
            Camera.main.orthographicSize = newSize;
            Invoke("ResetZoom", duration);
        }
    }

    private void ResetZoom()
    {
        Camera.main.orthographicSize = originalSize;
        isZoomedOut = false;
    }
}
