using UnityEngine;

namespace GAMEPLAY
{
    public class CameraScaler : MonoBehaviour
    {
        [Header("Camera Settings")]
        [SerializeField] private float _referenceHeight = 1920f;
        [SerializeField] private float _referenceWidth = 1080f;
        [SerializeField] private float _baseSize = 5f;
        
        private Camera _camera = null;

        private void Awake()
        {
            _camera = GetComponent<Camera>();
            ScaleCamera();
        }

        private void ScaleCamera()
        {
            if (_camera == null)
            {
                return;
            }

            float screenAspect = (float)Screen.width / Screen.height;
            float referenceAspect = _referenceWidth / _referenceHeight;
            
            if (screenAspect >= referenceAspect)
            {
                _camera.orthographicSize = _baseSize;
            }
            else
            {
                _camera.orthographicSize = _baseSize * (referenceAspect / screenAspect);
            }
        }
    }
}
