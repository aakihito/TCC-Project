//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/_Input/GameControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @GameControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""Player Movement"",
            ""id"": ""16683e9d-636d-4c4e-b25c-e231f5aea2f4"",
            ""actions"": [
                {
                    ""name"": ""View"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e896f2d5-f17e-467f-b014-91c41d8de0e0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Walk"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1599686a-2c63-4ceb-b7e7-7442402feefa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Lock On Target Left"",
                    ""type"": ""Button"",
                    ""id"": ""773ec192-738a-4cc7-8f6b-25db640816ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Lock On Target Right"",
                    ""type"": ""Button"",
                    ""id"": ""4a62874d-14a0-41a0-973c-bd299e1806b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3a317bb1-404c-4d8c-bd42-eeb3546d5cfb"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AWSD"",
                    ""id"": ""106aac6d-c63c-4596-9628-8015d8203005"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8f2fcee3-27e8-472e-bed0-1bf23e4356c2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""aa930f07-c51c-4e6c-820d-9dfcb805b088"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""99da194c-5c77-48f5-bbbb-e944dac80667"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3f78f178-28f9-4784-96cf-028de6e6d1c5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b132e032-132a-43ac-9c6b-105964c8409f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lock On Target Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e1774d0-aaae-4b5b-ae5e-ee6fb440a688"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lock On Target Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player Actions"",
            ""id"": ""f27feaa6-3293-496d-b528-e39532529f70"",
            ""actions"": [
                {
                    ""name"": ""LB"",
                    ""type"": ""Button"",
                    ""id"": ""4603bbc8-697a-4cac-b674-66b67d33c146"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RB"",
                    ""type"": ""Button"",
                    ""id"": ""8a851730-728c-43d5-a69a-cdf00e11bb73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Critical Attack"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4393c9d9-48d4-44a6-8776-01bc7f527209"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LT"",
                    ""type"": ""Button"",
                    ""id"": ""53e96dcf-ed23-4c74-91c6-ab674af4e7a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TH"",
                    ""type"": ""Button"",
                    ""id"": ""0133a50b-73c1-490c-8eab-922f3686f7ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""StepBack"",
                    ""type"": ""Button"",
                    ""id"": ""e025971e-66bd-49c0-86b2-a854f6483260"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""5ff80b07-f118-4cc4-ab06-b55c61aa5578"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""efadda80-0571-4bec-8942-f50dc32c07e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""4a3f588f-4a6e-44d8-ad93-47e1a0794429"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CameraLockOn"",
                    ""type"": ""Button"",
                    ""id"": ""eea98e9b-550d-477b-81b6-baf8296c3f8c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""3adf00dd-63c6-444d-837d-d00b99fe7737"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aiming"",
                    ""type"": ""PassThrough"",
                    ""id"": ""76762242-fad6-4775-a73d-1dc000898dd8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""332803ed-c334-43f4-acd4-98950910740d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5592f20e-3517-4e1a-b3f1-64ea5d5f19c0"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b414315-df36-4b6d-ab1b-e7a3e616372a"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""980eff9d-b8b9-4c00-8c3a-b78a3a2efc48"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d9217bc-dce4-4b18-ab62-8709fe5ea755"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bd47597-e11a-4b9b-b869-0d552d6684e4"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StepBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62b315db-faaf-4545-8432-b89d33213c2f"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1243838-6aef-48ff-99c0-fc685cb76225"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraLockOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf3ed446-3e79-4528-9134-b7118f33e8c7"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""426042d7-3e0d-4771-bd9a-b380d940bff1"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ff47bc2-b219-466e-921b-732e1acf4879"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Critical Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfa24f79-0817-4c6c-890e-f18b766cf1b2"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Movement
        m_PlayerMovement = asset.FindActionMap("Player Movement", throwIfNotFound: true);
        m_PlayerMovement_View = m_PlayerMovement.FindAction("View", throwIfNotFound: true);
        m_PlayerMovement_Walk = m_PlayerMovement.FindAction("Walk", throwIfNotFound: true);
        m_PlayerMovement_LockOnTargetLeft = m_PlayerMovement.FindAction("Lock On Target Left", throwIfNotFound: true);
        m_PlayerMovement_LockOnTargetRight = m_PlayerMovement.FindAction("Lock On Target Right", throwIfNotFound: true);
        // Player Actions
        m_PlayerActions = asset.FindActionMap("Player Actions", throwIfNotFound: true);
        m_PlayerActions_LB = m_PlayerActions.FindAction("LB", throwIfNotFound: true);
        m_PlayerActions_RB = m_PlayerActions.FindAction("RB", throwIfNotFound: true);
        m_PlayerActions_CriticalAttack = m_PlayerActions.FindAction("Critical Attack", throwIfNotFound: true);
        m_PlayerActions_LT = m_PlayerActions.FindAction("LT", throwIfNotFound: true);
        m_PlayerActions_TH = m_PlayerActions.FindAction("TH", throwIfNotFound: true);
        m_PlayerActions_StepBack = m_PlayerActions.FindAction("StepBack", throwIfNotFound: true);
        m_PlayerActions_Pause = m_PlayerActions.FindAction("Pause", throwIfNotFound: true);
        m_PlayerActions_Interact = m_PlayerActions.FindAction("Interact", throwIfNotFound: true);
        m_PlayerActions_Run = m_PlayerActions.FindAction("Run", throwIfNotFound: true);
        m_PlayerActions_CameraLockOn = m_PlayerActions.FindAction("CameraLockOn", throwIfNotFound: true);
        m_PlayerActions_Block = m_PlayerActions.FindAction("Block", throwIfNotFound: true);
        m_PlayerActions_Aiming = m_PlayerActions.FindAction("Aiming", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player Movement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_View;
    private readonly InputAction m_PlayerMovement_Walk;
    private readonly InputAction m_PlayerMovement_LockOnTargetLeft;
    private readonly InputAction m_PlayerMovement_LockOnTargetRight;
    public struct PlayerMovementActions
    {
        private @GameControls m_Wrapper;
        public PlayerMovementActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @View => m_Wrapper.m_PlayerMovement_View;
        public InputAction @Walk => m_Wrapper.m_PlayerMovement_Walk;
        public InputAction @LockOnTargetLeft => m_Wrapper.m_PlayerMovement_LockOnTargetLeft;
        public InputAction @LockOnTargetRight => m_Wrapper.m_PlayerMovement_LockOnTargetRight;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @View.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnView;
                @View.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnView;
                @View.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnView;
                @Walk.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnWalk;
                @LockOnTargetLeft.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnTargetLeft;
                @LockOnTargetLeft.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnTargetLeft;
                @LockOnTargetLeft.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnTargetLeft;
                @LockOnTargetRight.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnTargetRight;
                @LockOnTargetRight.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnTargetRight;
                @LockOnTargetRight.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnTargetRight;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @View.started += instance.OnView;
                @View.performed += instance.OnView;
                @View.canceled += instance.OnView;
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @LockOnTargetLeft.started += instance.OnLockOnTargetLeft;
                @LockOnTargetLeft.performed += instance.OnLockOnTargetLeft;
                @LockOnTargetLeft.canceled += instance.OnLockOnTargetLeft;
                @LockOnTargetRight.started += instance.OnLockOnTargetRight;
                @LockOnTargetRight.performed += instance.OnLockOnTargetRight;
                @LockOnTargetRight.canceled += instance.OnLockOnTargetRight;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // Player Actions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_LB;
    private readonly InputAction m_PlayerActions_RB;
    private readonly InputAction m_PlayerActions_CriticalAttack;
    private readonly InputAction m_PlayerActions_LT;
    private readonly InputAction m_PlayerActions_TH;
    private readonly InputAction m_PlayerActions_StepBack;
    private readonly InputAction m_PlayerActions_Pause;
    private readonly InputAction m_PlayerActions_Interact;
    private readonly InputAction m_PlayerActions_Run;
    private readonly InputAction m_PlayerActions_CameraLockOn;
    private readonly InputAction m_PlayerActions_Block;
    private readonly InputAction m_PlayerActions_Aiming;
    public struct PlayerActionsActions
    {
        private @GameControls m_Wrapper;
        public PlayerActionsActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LB => m_Wrapper.m_PlayerActions_LB;
        public InputAction @RB => m_Wrapper.m_PlayerActions_RB;
        public InputAction @CriticalAttack => m_Wrapper.m_PlayerActions_CriticalAttack;
        public InputAction @LT => m_Wrapper.m_PlayerActions_LT;
        public InputAction @TH => m_Wrapper.m_PlayerActions_TH;
        public InputAction @StepBack => m_Wrapper.m_PlayerActions_StepBack;
        public InputAction @Pause => m_Wrapper.m_PlayerActions_Pause;
        public InputAction @Interact => m_Wrapper.m_PlayerActions_Interact;
        public InputAction @Run => m_Wrapper.m_PlayerActions_Run;
        public InputAction @CameraLockOn => m_Wrapper.m_PlayerActions_CameraLockOn;
        public InputAction @Block => m_Wrapper.m_PlayerActions_Block;
        public InputAction @Aiming => m_Wrapper.m_PlayerActions_Aiming;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @LB.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLB;
                @LB.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLB;
                @LB.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLB;
                @RB.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRB;
                @RB.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRB;
                @RB.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRB;
                @CriticalAttack.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnCriticalAttack;
                @CriticalAttack.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnCriticalAttack;
                @CriticalAttack.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnCriticalAttack;
                @LT.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLT;
                @LT.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLT;
                @LT.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLT;
                @TH.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnTH;
                @TH.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnTH;
                @TH.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnTH;
                @StepBack.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnStepBack;
                @StepBack.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnStepBack;
                @StepBack.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnStepBack;
                @Pause.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnPause;
                @Interact.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInteract;
                @Run.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRun;
                @CameraLockOn.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnCameraLockOn;
                @CameraLockOn.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnCameraLockOn;
                @CameraLockOn.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnCameraLockOn;
                @Block.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnBlock;
                @Aiming.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnAiming;
                @Aiming.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnAiming;
                @Aiming.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnAiming;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LB.started += instance.OnLB;
                @LB.performed += instance.OnLB;
                @LB.canceled += instance.OnLB;
                @RB.started += instance.OnRB;
                @RB.performed += instance.OnRB;
                @RB.canceled += instance.OnRB;
                @CriticalAttack.started += instance.OnCriticalAttack;
                @CriticalAttack.performed += instance.OnCriticalAttack;
                @CriticalAttack.canceled += instance.OnCriticalAttack;
                @LT.started += instance.OnLT;
                @LT.performed += instance.OnLT;
                @LT.canceled += instance.OnLT;
                @TH.started += instance.OnTH;
                @TH.performed += instance.OnTH;
                @TH.canceled += instance.OnTH;
                @StepBack.started += instance.OnStepBack;
                @StepBack.performed += instance.OnStepBack;
                @StepBack.canceled += instance.OnStepBack;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @CameraLockOn.started += instance.OnCameraLockOn;
                @CameraLockOn.performed += instance.OnCameraLockOn;
                @CameraLockOn.canceled += instance.OnCameraLockOn;
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
                @Aiming.started += instance.OnAiming;
                @Aiming.performed += instance.OnAiming;
                @Aiming.canceled += instance.OnAiming;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);
    public interface IPlayerMovementActions
    {
        void OnView(InputAction.CallbackContext context);
        void OnWalk(InputAction.CallbackContext context);
        void OnLockOnTargetLeft(InputAction.CallbackContext context);
        void OnLockOnTargetRight(InputAction.CallbackContext context);
    }
    public interface IPlayerActionsActions
    {
        void OnLB(InputAction.CallbackContext context);
        void OnRB(InputAction.CallbackContext context);
        void OnCriticalAttack(InputAction.CallbackContext context);
        void OnLT(InputAction.CallbackContext context);
        void OnTH(InputAction.CallbackContext context);
        void OnStepBack(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnCameraLockOn(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnAiming(InputAction.CallbackContext context);
    }
}
