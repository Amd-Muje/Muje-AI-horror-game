using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] private PlayerCharacterMovement _movement;
    [SerializeField] private PlayerCharacterStamina _stamina;
    [SerializeField] private InventoryManager _inventory;
    [SerializeField] private InteractDetector _interactDetector;
    [SerializeField] private CameraManager _camera;
    [SerializeField] private InputManager _input;
    [SerializeField] private Flashlight _flashlight;

    public InteractDetector InteractDetector => _interactDetector;
    public PlayerCharacterMovement Movement => _movement;
    public PlayerCharacterStamina Stamina => _stamina;
    public InventoryManager Inventory => _inventory;

    public InputManager Input => _input;
    public CameraManager Camera => _camera;

    public Flashlight Flashlight => _flashlight;

    public bool IsHiding { get; private set; }

    public void SetIsHiding(bool isHiding) 
    {
        IsHiding = isHiding;
    }
    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Death()
    {
        Debug.Log("Player Died");
    }
}
