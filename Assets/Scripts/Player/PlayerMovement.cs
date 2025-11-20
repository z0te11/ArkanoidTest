using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float _moveSpeed = 12f;
    [SerializeField] private float _swipeSensitivity = 2f;
    
    private Camera _mainCamera;
    private float _minX, _maxX;
    private float _paddleHalfWidth;

    private void Start()
    {
        _mainCamera = Camera.main;
        _paddleHalfWidth = transform.localScale.x / 2f;
        CalculateBoundaries();
    }

    void CalculateBoundaries()
    {
        if (_mainCamera != null)
        {
            float screenAspect = (float)Screen.width / Screen.height;
            float cameraHeight = _mainCamera.orthographicSize;
            float cameraWidth = cameraHeight * screenAspect;
            
            _minX = -cameraWidth + _paddleHalfWidth - 2f;
            _maxX = cameraWidth - _paddleHalfWidth + 2f;
        }
    }

    public void ProcessSwipe(Vector2 currentPosition, Vector2 startPosition)
    {
        float deltaX = (currentPosition.x - startPosition.x) / Screen.width;
        
        if (Mathf.Abs(deltaX) > 0.01f)
        {
            float movement = deltaX * _moveSpeed * _swipeSensitivity;
            MovePaddle(movement);
        }
    }

    private void MovePaddle(float movement)
    {
        float newX = transform.position.x + movement * Time.deltaTime;
        newX = Mathf.Clamp(newX, _minX, _maxX);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }

}