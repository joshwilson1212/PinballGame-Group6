//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/input/Pinballinput.inputactions
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

public partial class @Pinballinput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Pinballinput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Pinballinput"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""665b3ad4-e880-4bda-9669-5f75473f7e55"",
            ""actions"": [
                {
                    ""name"": ""Launch Ball"",
                    ""type"": ""Button"",
                    ""id"": ""fce466b7-3c08-4bb2-9888-152003fb5768"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightFlipper"",
                    ""type"": ""Button"",
                    ""id"": ""9adaabdf-4eeb-4ece-aea8-95edbf78e0f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftFlipper"",
                    ""type"": ""Button"",
                    ""id"": ""c3ecd0f8-1e86-4cd0-99c8-27cb96e59bd5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e0ac9b6a-a999-4dcc-87ab-c2fb59d552eb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Launch Ball"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c3a4f53-d02d-452a-b418-2e6519b3cc26"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightFlipper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf0b0787-6b8d-4a96-b50e-872e39344126"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftFlipper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_LaunchBall = m_Default.FindAction("Launch Ball", throwIfNotFound: true);
        m_Default_RightFlipper = m_Default.FindAction("RightFlipper", throwIfNotFound: true);
        m_Default_LeftFlipper = m_Default.FindAction("LeftFlipper", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private List<IDefaultActions> m_DefaultActionsCallbackInterfaces = new List<IDefaultActions>();
    private readonly InputAction m_Default_LaunchBall;
    private readonly InputAction m_Default_RightFlipper;
    private readonly InputAction m_Default_LeftFlipper;
    public struct DefaultActions
    {
        private @Pinballinput m_Wrapper;
        public DefaultActions(@Pinballinput wrapper) { m_Wrapper = wrapper; }
        public InputAction @LaunchBall => m_Wrapper.m_Default_LaunchBall;
        public InputAction @RightFlipper => m_Wrapper.m_Default_RightFlipper;
        public InputAction @LeftFlipper => m_Wrapper.m_Default_LeftFlipper;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void AddCallbacks(IDefaultActions instance)
        {
            if (instance == null || m_Wrapper.m_DefaultActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DefaultActionsCallbackInterfaces.Add(instance);
            @LaunchBall.started += instance.OnLaunchBall;
            @LaunchBall.performed += instance.OnLaunchBall;
            @LaunchBall.canceled += instance.OnLaunchBall;
            @RightFlipper.started += instance.OnRightFlipper;
            @RightFlipper.performed += instance.OnRightFlipper;
            @RightFlipper.canceled += instance.OnRightFlipper;
            @LeftFlipper.started += instance.OnLeftFlipper;
            @LeftFlipper.performed += instance.OnLeftFlipper;
            @LeftFlipper.canceled += instance.OnLeftFlipper;
        }

        private void UnregisterCallbacks(IDefaultActions instance)
        {
            @LaunchBall.started -= instance.OnLaunchBall;
            @LaunchBall.performed -= instance.OnLaunchBall;
            @LaunchBall.canceled -= instance.OnLaunchBall;
            @RightFlipper.started -= instance.OnRightFlipper;
            @RightFlipper.performed -= instance.OnRightFlipper;
            @RightFlipper.canceled -= instance.OnRightFlipper;
            @LeftFlipper.started -= instance.OnLeftFlipper;
            @LeftFlipper.performed -= instance.OnLeftFlipper;
            @LeftFlipper.canceled -= instance.OnLeftFlipper;
        }

        public void RemoveCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDefaultActions instance)
        {
            foreach (var item in m_Wrapper.m_DefaultActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DefaultActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IDefaultActions
    {
        void OnLaunchBall(InputAction.CallbackContext context);
        void OnRightFlipper(InputAction.CallbackContext context);
        void OnLeftFlipper(InputAction.CallbackContext context);
    }
}
