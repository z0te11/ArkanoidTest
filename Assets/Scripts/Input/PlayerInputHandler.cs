using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMove;
    [SerializeField] private UserInputSystem _userInput;

    private float _deadZone = 0.01f;

    private Vector2 _startTouchPosition;

    void Start()
    {
        if (_userInput != null)
        {
            _userInput.OnSwipe.AddListener(HandleSwipe);
            _userInput.OnTouchStart.AddListener(OnTouchStarted);
        }
        else
        {
            Debug.LogError("UserInputSystem not found!");
        }
    }

    void OnTouchStarted()
    {
        _startTouchPosition = _userInput.GetStartTouchPosition();
    }

    void HandleSwipe(Vector2 currentPosition)
    {
        if (_playerMove == null) return;

        float deltaX = (currentPosition.x - _startTouchPosition.x) / Screen.width;
        
        if (Mathf.Abs(deltaX) > _deadZone)
        {
            _playerMove.ProcessSwipe(currentPosition, _startTouchPosition);
            
            _startTouchPosition = currentPosition;
        }
    }

    void OnDestroy()
    {
        // Отписываемся от событий
        if (_userInput != null)
        {
            _userInput.OnSwipe.RemoveListener(HandleSwipe);
            _userInput.OnTouchStart.RemoveListener(OnTouchStarted);
        }
    }
}
