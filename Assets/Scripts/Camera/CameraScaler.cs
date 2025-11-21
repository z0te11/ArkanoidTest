using UnityEngine;

namespace GAMEPLAY
{
    public class CameraScaler : MonoBehaviour
    {
        [SerializeField] private float _baseSize = 5f;

        private void Awake()
        {
            ScaleCamera();
        }

        private void ScaleCamera()
        {
            Camera cam = GetComponent<Camera>();
            float screenHeight = Screen.height;
            cam.orthographicSize = _baseSize * (1080f / screenHeight);
        }
    }
}
