//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GameplayActions"",
            ""id"": ""5f2e5a41-5634-4ec2-bc7c-3a32eb645c99"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""1da98102-51fd-48e3-b7f2-8e87b7a7b198"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""c7be4be8-2950-4d53-97ef-3fd08daceeed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""bd2678de-6b7f-4ba6-b418-6596f4ff5dc5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""8d2ae616-a7e3-49ff-95da-9540b53c9e3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""03cb6014-8517-4f86-b6fc-8e36921d79ae"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4605363f-246d-4e8b-9c1d-6add59129714"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5965bd27-892e-49b0-aaab-3dc6f286360d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8f99703c-0ce2-475d-a644-c0e3cd2750b2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d7b844c5-c8ea-47f5-8ad3-88a28195a6f5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""89576353-1806-4c38-aa92-074053acac93"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0ef4381-bda3-4da3-bdf9-6b9959700446"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2abc646-d9dc-43ca-a1a2-58cea19b76bb"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameplayActions
        m_GameplayActions = asset.FindActionMap("GameplayActions", throwIfNotFound: true);
        m_GameplayActions_Movement = m_GameplayActions.FindAction("Movement", throwIfNotFound: true);
        m_GameplayActions_Shoot = m_GameplayActions.FindAction("Shoot", throwIfNotFound: true);
        m_GameplayActions_Pause = m_GameplayActions.FindAction("Pause", throwIfNotFound: true);
        m_GameplayActions_Reset = m_GameplayActions.FindAction("Reset", throwIfNotFound: true);
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

    // GameplayActions
    private readonly InputActionMap m_GameplayActions;
    private List<IGameplayActionsActions> m_GameplayActionsActionsCallbackInterfaces = new List<IGameplayActionsActions>();
    private readonly InputAction m_GameplayActions_Movement;
    private readonly InputAction m_GameplayActions_Shoot;
    private readonly InputAction m_GameplayActions_Pause;
    private readonly InputAction m_GameplayActions_Reset;
    public struct GameplayActionsActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GameplayActions_Movement;
        public InputAction @Shoot => m_Wrapper.m_GameplayActions_Shoot;
        public InputAction @Pause => m_Wrapper.m_GameplayActions_Pause;
        public InputAction @Reset => m_Wrapper.m_GameplayActions_Reset;
        public InputActionMap Get() { return m_Wrapper.m_GameplayActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActionsActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @Reset.started += instance.OnReset;
            @Reset.performed += instance.OnReset;
            @Reset.canceled += instance.OnReset;
        }

        private void UnregisterCallbacks(IGameplayActionsActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @Reset.started -= instance.OnReset;
            @Reset.performed -= instance.OnReset;
            @Reset.canceled -= instance.OnReset;
        }

        public void RemoveCallbacks(IGameplayActionsActions instance)
        {
            if (m_Wrapper.m_GameplayActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActionsActions @GameplayActions => new GameplayActionsActions(this);
    public interface IGameplayActionsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
    }
}
