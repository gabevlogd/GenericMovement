//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/GenericMovement/MovementInput.inputactions
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

public partial class @MovementInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MovementInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MovementInput"",
    ""maps"": [
        {
            ""name"": ""Translation"",
            ""id"": ""2a531c39-6aa4-43a8-ab0c-f91aed08c940"",
            ""actions"": [
                {
                    ""name"": ""Forward"",
                    ""type"": ""Value"",
                    ""id"": ""6d1a2159-9501-4e3a-9642-7942708977da"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Value"",
                    ""id"": ""f1fb4c29-8caa-4c31-bfc0-33ed215cec7f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Value"",
                    ""id"": ""14c5fbd5-c4c4-4cfe-8001-7e5344e9a6b6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a460956f-0e98-40ba-8412-6d6e49e18f3d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""24e45fb0-79eb-43c6-bfa6-af9a615e023f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4a8f17e4-7fc9-4b6a-aef3-cb32d0335bd0"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3119a58e-dae4-4bd0-952b-ac865f650caf"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1ce47819-e962-48dd-93c8-98c740b4d3bd"",
                    ""path"": ""<Keyboard>/#(E)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2e2f8e0c-0405-4f32-9d93-2ad868e13667"",
                    ""path"": ""<Keyboard>/#(Q)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""765f1baf-1885-4306-80cf-a41fa657c3ab"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""176a14ba-ad86-4856-a9fc-494d14e2167a"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8810bb44-1718-426f-baa1-3d4a31325df7"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Rotation"",
            ""id"": ""b9f00345-8cd7-4aa1-9c17-6aff41cf2b4d"",
            ""actions"": [
                {
                    ""name"": ""Pitch"",
                    ""type"": ""Value"",
                    ""id"": ""840524ee-d7b8-433b-8b6c-a5465db5917a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""672aef24-5765-4bf0-ab17-6883e9cbbe71"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Value"",
                    ""id"": ""844f948b-3ab6-426e-96a4-3f7b041bacb0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""426e221e-53fc-410a-8871-cf7288e28151"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87c1edae-9215-4fc3-934b-c7a8c9dc6b89"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""331470a7-2ee6-4b60-a080-886af44b74a1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""54218114-ccce-43d2-83c6-d6d9e9ab940c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""40901ecc-b252-4899-a090-d35450d570c0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Translation
        m_Translation = asset.FindActionMap("Translation", throwIfNotFound: true);
        m_Translation_Forward = m_Translation.FindAction("Forward", throwIfNotFound: true);
        m_Translation_Up = m_Translation.FindAction("Up", throwIfNotFound: true);
        m_Translation_Right = m_Translation.FindAction("Right", throwIfNotFound: true);
        // Rotation
        m_Rotation = asset.FindActionMap("Rotation", throwIfNotFound: true);
        m_Rotation_Pitch = m_Rotation.FindAction("Pitch", throwIfNotFound: true);
        m_Rotation_Yaw = m_Rotation.FindAction("Yaw", throwIfNotFound: true);
        m_Rotation_Roll = m_Rotation.FindAction("Roll", throwIfNotFound: true);
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

    // Translation
    private readonly InputActionMap m_Translation;
    private ITranslationActions m_TranslationActionsCallbackInterface;
    private readonly InputAction m_Translation_Forward;
    private readonly InputAction m_Translation_Up;
    private readonly InputAction m_Translation_Right;
    public struct TranslationActions
    {
        private @MovementInput m_Wrapper;
        public TranslationActions(@MovementInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forward => m_Wrapper.m_Translation_Forward;
        public InputAction @Up => m_Wrapper.m_Translation_Up;
        public InputAction @Right => m_Wrapper.m_Translation_Right;
        public InputActionMap Get() { return m_Wrapper.m_Translation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TranslationActions set) { return set.Get(); }
        public void SetCallbacks(ITranslationActions instance)
        {
            if (m_Wrapper.m_TranslationActionsCallbackInterface != null)
            {
                @Forward.started -= m_Wrapper.m_TranslationActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_TranslationActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_TranslationActionsCallbackInterface.OnForward;
                @Up.started -= m_Wrapper.m_TranslationActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_TranslationActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_TranslationActionsCallbackInterface.OnUp;
                @Right.started -= m_Wrapper.m_TranslationActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_TranslationActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_TranslationActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_TranslationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public TranslationActions @Translation => new TranslationActions(this);

    // Rotation
    private readonly InputActionMap m_Rotation;
    private IRotationActions m_RotationActionsCallbackInterface;
    private readonly InputAction m_Rotation_Pitch;
    private readonly InputAction m_Rotation_Yaw;
    private readonly InputAction m_Rotation_Roll;
    public struct RotationActions
    {
        private @MovementInput m_Wrapper;
        public RotationActions(@MovementInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pitch => m_Wrapper.m_Rotation_Pitch;
        public InputAction @Yaw => m_Wrapper.m_Rotation_Yaw;
        public InputAction @Roll => m_Wrapper.m_Rotation_Roll;
        public InputActionMap Get() { return m_Wrapper.m_Rotation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RotationActions set) { return set.Get(); }
        public void SetCallbacks(IRotationActions instance)
        {
            if (m_Wrapper.m_RotationActionsCallbackInterface != null)
            {
                @Pitch.started -= m_Wrapper.m_RotationActionsCallbackInterface.OnPitch;
                @Pitch.performed -= m_Wrapper.m_RotationActionsCallbackInterface.OnPitch;
                @Pitch.canceled -= m_Wrapper.m_RotationActionsCallbackInterface.OnPitch;
                @Yaw.started -= m_Wrapper.m_RotationActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_RotationActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_RotationActionsCallbackInterface.OnYaw;
                @Roll.started -= m_Wrapper.m_RotationActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_RotationActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_RotationActionsCallbackInterface.OnRoll;
            }
            m_Wrapper.m_RotationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pitch.started += instance.OnPitch;
                @Pitch.performed += instance.OnPitch;
                @Pitch.canceled += instance.OnPitch;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
            }
        }
    }
    public RotationActions @Rotation => new RotationActions(this);
    public interface ITranslationActions
    {
        void OnForward(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
    public interface IRotationActions
    {
        void OnPitch(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
    }
}
