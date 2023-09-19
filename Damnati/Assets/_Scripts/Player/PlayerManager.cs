using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : CharacterManager
{
    private Animator _animator;
    private CameraHandler _cameraHandler;

    private InputHandler _inputHandler;
    private PlayerLocomotionManager _playerLocomotionManager;
    private PlayerWeaponSlotManager _playerWeaponSlotManager;
    private PlayerCombatManager _playerCombatManager;
    private PlayerStatsManager _playerStatsManager;
    private PlayerAnimatorManager _playerAnimatorManager;
    private PlayerEffectsManager _playerEffectsManager;
    private PlayerInventoryManager _playerInventoryManager;
    private PlayerEquipmentManager _playerEquipmentManager;

    [Header("Item Collect Components")]
    [Space(15)] 
    private InteractableUI _interactableUI;
    [SerializeField] private GameObject _interactableUIGameObject;
    [SerializeField] private GameObject _itemInteractableGameObject;

    #region GET & SET

    public GameObject ItemInteractableGameObject {get { return _itemInteractableGameObject; } set { _itemInteractableGameObject = value; }}

    public PlayerAnimatorManager PlayerAnimator { get { return _playerAnimatorManager; }}
    public InputHandler PlayerInput { get { return _inputHandler; }}
    public PlayerWeaponSlotManager PlayerWeaponSlot { get { return _playerWeaponSlotManager; }}
    public PlayerInventoryManager PlayerInventory { get { return _playerInventoryManager; }}
    public PlayerLocomotionManager PlayerLocomotion { get { return _playerLocomotionManager; }}
    public PlayerStatsManager PlayerStats { get { return _playerStatsManager; }}
    public PlayerCombatManager PlayerCombat { get { return _playerCombatManager; }}
    public PlayerEffectsManager PlayerEffects { get { return _playerEffectsManager; }}
    public PlayerEquipmentManager PlayerEquipment { get { return _playerEquipmentManager; }}
    public CameraHandler PlayerCamera { get { return _cameraHandler; }}
    #endregion  

    protected override void Awake() 
    {
        base.Awake();
        _cameraHandler = FindObjectOfType<CameraHandler>();
        _inputHandler = FindObjectOfType<InputHandler>();
        _animator = GetComponent<Animator>();
        _playerLocomotionManager = GetComponent<PlayerLocomotionManager>();
        _playerStatsManager = GetComponent<PlayerStatsManager>();
        _playerAnimatorManager = GetComponent<PlayerAnimatorManager>();
        _playerEffectsManager = GetComponent<PlayerEffectsManager>();
        _playerCombatManager = GetComponent<PlayerCombatManager>();
        _playerWeaponSlotManager = GetComponent<PlayerWeaponSlotManager>();
        _playerInventoryManager = GetComponent<PlayerInventoryManager>();
        _playerEquipmentManager = GetComponent<PlayerEquipmentManager>();
        _interactableUI = FindObjectOfType<InteractableUI>();
    }
    private void Update()
    {
        float delta = Time.deltaTime;

        IsInteracting = _animator.GetBool("IsInteracting");
        CanDoCombo = _animator.GetBool("CanDoCombo");
        IsInvulnerable = _animator.GetBool("IsInvulnerable");
        IsHoldingArrow = _animator.GetBool("IsHoldingArrow");
        _animator.SetBool("IsTwoHandingWeapon", IsTwoHandingWeapon);
        _animator.SetBool("IsInAir", IsInAir);
        _animator.SetBool("IsDead", _playerStatsManager.IsDead);
        _animator.SetBool("IsBlocking", IsBlocking);

        _inputHandler.TickInput(delta);
        _playerAnimatorManager.canRotate = _animator.GetBool("CanRotate");
        _playerLocomotionManager.HandleDodge();
        _playerStatsManager.RegenerateStamina();

        CheckForInteractableObject();

        if(_inputHandler.IsHitEnemy && !_inputHandler.IsInRage)
        {
            _playerStatsManager.RegenerateRage();
        }
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        _playerLocomotionManager.HandleGravity(_playerLocomotionManager.MoveDirection);
        _playerLocomotionManager.HandleMovement();
        _playerLocomotionManager.HandleRotation();
        _playerEffectsManager.HandleAllBuildUpEffects();
    }
    
    private void LateUpdate() 
    {
        _inputHandler.SBFlag = false;

        HandleSprinting();
        
        if (_cameraHandler != null)
        {
            _cameraHandler.FollowTarget();
           _cameraHandler.HandleCameraRotation();
        }   
        if(IsInAir)
        {
            _playerLocomotionManager.InAirTimer = _playerLocomotionManager.InAirTimer + Time.deltaTime;
        } 
    }
    
    public void CheckForInteractableObject()
    {
        RaycastHit hit;

        if(Physics.SphereCast(transform.position, 0.3f, transform.forward, out hit, 1f, _playerLocomotionManager.IgnoreForGroundCheck))
        {
            if(hit.collider.tag == "Interactable")
            {
                Interactable interactableObject = hit.collider.GetComponent<Interactable>();

                if(interactableObject != null)
                {
                    string interactableText = interactableObject.InteractableText;
                    _interactableUI.InteractableText.text = interactableText;
                    _interactableUIGameObject.SetActive(true);
                    
                    if(_inputHandler.InteractInput)
                    {
                        hit.collider.GetComponent<Interactable>().Interact(this);
                    }
                }
            }
        }
        else
        {
            if(_interactableUIGameObject != null)
            {
                _interactableUIGameObject.SetActive(false);
            }
            if(_itemInteractableGameObject != null && _inputHandler.InteractInput)
            {
                _itemInteractableGameObject.SetActive(false);
            }
        }
    }
    private void HandleSprinting()
    {
        if(_inputHandler.RunFlag)
        {
            if(_playerStatsManager.CurrentStamina <= 0)
            {
                IsSprinting = false;
                _inputHandler.RunFlag = false;
            }
            if(_inputHandler.MoveAmount > 0.5f && _playerStatsManager.CurrentStamina > 0)
            {
                IsSprinting = true;
            }
        }
        else
        {
            IsSprinting = false;
        }
    }
}
