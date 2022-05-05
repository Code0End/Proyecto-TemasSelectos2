//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""controls"",
    ""maps"": [
        {
            ""name"": ""am1"",
            ""id"": ""c96581b9-befc-4086-ab35-5a8b9735f2a6"",
            ""actions"": [
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""67d006a7-d17f-4a9c-9a8b-78d59ab2aa37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""click"",
                    ""type"": ""Button"",
                    ""id"": ""9e095516-7c53-42bd-9dea-f6153abfe1b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""movement"",
                    ""type"": ""Value"",
                    ""id"": ""73f9756f-c729-4793-9cb8-3e9098c9a273"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7dceeb3-3b49-4f8f-8c42-0856ba4de761"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5ad5c6f-b67e-421a-86a3-deb24b942ff4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e5079625-e2b3-4f58-b905-9e6a5200717b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""56b0649f-96d2-470e-b5cb-7eacae2b82b4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d5b6e5d5-adfb-4189-b501-bce85ac9559d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1ca0db1a-01e3-4d6b-97b3-8688a08cbf2e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1118db9c-0ec2-430a-9155-56a491667fe5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // am1
        m_am1 = asset.FindActionMap("am1", throwIfNotFound: true);
        m_am1_jump = m_am1.FindAction("jump", throwIfNotFound: true);
        m_am1_click = m_am1.FindAction("click", throwIfNotFound: true);
        m_am1_movement = m_am1.FindAction("movement", throwIfNotFound: true);
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

    // am1
    private readonly InputActionMap m_am1;
    private IAm1Actions m_Am1ActionsCallbackInterface;
    private readonly InputAction m_am1_jump;
    private readonly InputAction m_am1_click;
    private readonly InputAction m_am1_movement;
    public struct Am1Actions
    {
        private @Controls m_Wrapper;
        public Am1Actions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @jump => m_Wrapper.m_am1_jump;
        public InputAction @click => m_Wrapper.m_am1_click;
        public InputAction @movement => m_Wrapper.m_am1_movement;
        public InputActionMap Get() { return m_Wrapper.m_am1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Am1Actions set) { return set.Get(); }
        public void SetCallbacks(IAm1Actions instance)
        {
            if (m_Wrapper.m_Am1ActionsCallbackInterface != null)
            {
                @jump.started -= m_Wrapper.m_Am1ActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_Am1ActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_Am1ActionsCallbackInterface.OnJump;
                @click.started -= m_Wrapper.m_Am1ActionsCallbackInterface.OnClick;
                @click.performed -= m_Wrapper.m_Am1ActionsCallbackInterface.OnClick;
                @click.canceled -= m_Wrapper.m_Am1ActionsCallbackInterface.OnClick;
                @movement.started -= m_Wrapper.m_Am1ActionsCallbackInterface.OnMovement;
                @movement.performed -= m_Wrapper.m_Am1ActionsCallbackInterface.OnMovement;
                @movement.canceled -= m_Wrapper.m_Am1ActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_Am1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @click.started += instance.OnClick;
                @click.performed += instance.OnClick;
                @click.canceled += instance.OnClick;
                @movement.started += instance.OnMovement;
                @movement.performed += instance.OnMovement;
                @movement.canceled += instance.OnMovement;
            }
        }
    }
    public Am1Actions @am1 => new Am1Actions(this);
    public interface IAm1Actions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
}
