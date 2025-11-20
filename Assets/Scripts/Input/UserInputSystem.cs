using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class UserInputSystem : MonoBehaviour
{
    [Header("Input Events")]
    public UnityEvent<Vector2> OnSwipe;
    public UnityEvent OnTouchStart;
    public UnityEvent OnTouchEnd;
    
    private InputAction _touchPositionAction;
    private Vector2 _startTouchPosition;
    private bool _isSwiping = false;

    private void OnEnable()
    {
        SetupInput();
    }

    private void OnDisable() 
    {
        _touchPositionAction?.Dispose();
    }

    private void SetupInput()
    {
        _touchPositionAction = new InputAction("TouchControl", InputActionType.Value, "<Pointer>/position");
        
        _touchPositionAction.started += OnTouchStarted;
        _touchPositionAction.performed += OnTouchMoved;
        _touchPositionAction.canceled += OnTouchEnded;
        
        _touchPositionAction.Enable();
    }

    private void OnTouchStarted(InputAction.CallbackContext context)
    {
        _startTouchPosition = context.ReadValue<Vector2>();
        _isSwiping = true;
        OnTouchStart?.Invoke();
    }

   private void OnTouchMoved(InputAction.CallbackContext context)
    {
        if (!_isSwiping) return;
        
        Vector2 currentPosition = context.ReadValue<Vector2>();
        OnSwipe?.Invoke(currentPosition);
    }

    private void OnTouchEnded(InputAction.CallbackContext context)
    {
        _isSwiping = false;
        OnTouchEnd?.Invoke();
    }

    public Vector2 GetStartTouchPosition()
    {
        return _startTouchPosition;
    }

    public bool IsSwiping()
    {
        return _isSwiping;
    }
}
