using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using static GameInputAction;

public class InputManager : MonoBehaviour, IPlayerActions
{

    private GameInputAction _inputAction;
    public UnityEvent<Vector2> OnMoveInput;
    public UnityEvent<bool> OnSprintInput;
    public UnityEvent OnInteractInput;
    public UnityEvent OnFlashlightInput;

    public void OnSprint(InputAction.CallbackContext context) 
    {
        if (context.performed)
        {
            OnSprintInput?.Invoke(true);
        }

        if (context.canceled)
        {
            OnSprintInput?.Invoke(false);
        }
    }

    public void OnFlashlight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            OnFlashlightInput?.Invoke();
        }
    }

    
    public void OnInteract(InputAction.CallbackContext context) 
    { 
        if(context.performed)
        {
            OnInteractInput?.Invoke();
        }
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log(context.ReadValue<Vector2>());
        OnMoveInput?.Invoke(context.ReadValue<Vector2>());
    }

    private void Awake()
    {
        _inputAction = new GameInputAction();
        _inputAction.Enable();
        _inputAction.Player.Enable();
        _inputAction.Player.SetCallbacks(this);
    }

    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
