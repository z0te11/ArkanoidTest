using UnityEngine;

public class CameraScaler : MonoBehaviour
{
    public float baseSize = 5f; // Размер камеры для разрешения 1080

    private void Awake()
    {
        ScaleCamera();
    }

    private void ScaleCamera()
    {
        Camera cam = GetComponent<Camera>();
        
        // Простое масштабирование относительно высоты экрана
        float screenHeight = Screen.height;
        cam.orthographicSize = baseSize * (1080f/ screenHeight);
    }
}
