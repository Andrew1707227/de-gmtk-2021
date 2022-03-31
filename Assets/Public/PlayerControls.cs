// GENERATED AUTOMATICALLY FROM 'Assets/Public/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""29e90204-ba19-49bf-9626-d6db11c39edd"",
            ""actions"": [
                {
                    ""name"": ""MagnetNeg"",
                    ""type"": ""Button"",
                    ""id"": ""59fce6f2-019b-45cc-8eba-1f331c95ace1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MagnetPos"",
                    ""type"": ""Button"",
                    ""id"": ""9498efc7-a4e8-4911-9692-c6fb9f4818cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""d7cdd74a-e7aa-4cec-a1e5-731ab4368c11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""6e263ff8-26a2-40af-9ea5-3dcd7f3d3734"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""a1c107a6-3391-4f01-b13a-f4a7e2001e4e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""26bfb56c-85e7-49f5-ab1c-98fa32bd35c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnyKey"",
                    ""type"": ""PassThrough"",
                    ""id"": ""09483f29-0ca7-4848-bc67-5ac09ed16f43"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""f0422d92-b167-493a-8138-f1fc822423e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""208e7083-a757-4ae1-aa23-50ee92f1e50e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MagnetNeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38107cd8-d768-4517-bd89-be36624a3989"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MagnetNeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca8696dd-9172-4223-87d5-c02570bb4025"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MagnetNeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f97e117-eea7-40c2-9f8b-7c1408190c60"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MagnetPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16c3e59d-1f68-4fba-8f8f-a411e3a216e5"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MagnetPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6701063-1f7a-4a8b-8bba-002d47f116c1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MagnetPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67fab971-a98a-4436-8cbe-dd3fd9833904"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d34eeb4b-4a63-4b03-b123-7edd17086990"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller;Mobile"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4df84a8-76c7-4d4d-a450-ee2534e5ae56"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e57016fa-f059-435a-bfe3-92147f14b2df"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller;Mobile"",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ee9dd5f-97f4-4a86-bb34-5ec8f53fd752"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfe2210e-52db-4263-8c1d-d20fcbb243aa"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller;Mobile"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68d6bb85-3419-477b-8b1c-32bed6114e03"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62d6b3fd-3652-445f-aaa6-f422a9a2541a"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller;Mobile"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86cdef21-3066-4566-8498-2b0b76fd616f"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9a93e6a-9e8b-461e-80c4-eb5ab734d1e1"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65cb8b8e-3550-468d-8f9e-797abacaed63"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f92ea21-0e17-484b-afb6-2100f6e140f8"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96c9720b-90b6-44a8-98f4-df75b4a71abc"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""059a1dad-bf8e-471c-9326-03cc64d52672"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97824c16-3424-4d8d-93af-fcec79ff8671"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mobile"",
            ""bindingGroup"": ""Mobile"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_MagnetNeg = m_Default.FindAction("MagnetNeg", throwIfNotFound: true);
        m_Default_MagnetPos = m_Default.FindAction("MagnetPos", throwIfNotFound: true);
        m_Default_MoveUp = m_Default.FindAction("MoveUp", throwIfNotFound: true);
        m_Default_MoveDown = m_Default.FindAction("MoveDown", throwIfNotFound: true);
        m_Default_MoveLeft = m_Default.FindAction("MoveLeft", throwIfNotFound: true);
        m_Default_MoveRight = m_Default.FindAction("MoveRight", throwIfNotFound: true);
        m_Default_AnyKey = m_Default.FindAction("AnyKey", throwIfNotFound: true);
        m_Default_Pause = m_Default.FindAction("Pause", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_MagnetNeg;
    private readonly InputAction m_Default_MagnetPos;
    private readonly InputAction m_Default_MoveUp;
    private readonly InputAction m_Default_MoveDown;
    private readonly InputAction m_Default_MoveLeft;
    private readonly InputAction m_Default_MoveRight;
    private readonly InputAction m_Default_AnyKey;
    private readonly InputAction m_Default_Pause;
    public struct DefaultActions
    {
        private @PlayerControls m_Wrapper;
        public DefaultActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MagnetNeg => m_Wrapper.m_Default_MagnetNeg;
        public InputAction @MagnetPos => m_Wrapper.m_Default_MagnetPos;
        public InputAction @MoveUp => m_Wrapper.m_Default_MoveUp;
        public InputAction @MoveDown => m_Wrapper.m_Default_MoveDown;
        public InputAction @MoveLeft => m_Wrapper.m_Default_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_Default_MoveRight;
        public InputAction @AnyKey => m_Wrapper.m_Default_AnyKey;
        public InputAction @Pause => m_Wrapper.m_Default_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @MagnetNeg.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMagnetNeg;
                @MagnetNeg.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMagnetNeg;
                @MagnetNeg.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMagnetNeg;
                @MagnetPos.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMagnetPos;
                @MagnetPos.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMagnetPos;
                @MagnetPos.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMagnetPos;
                @MoveUp.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMoveUp;
                @MoveUp.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMoveUp;
                @MoveUp.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMoveUp;
                @MoveDown.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMoveDown;
                @MoveDown.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMoveDown;
                @MoveDown.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMoveDown;
                @MoveLeft.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMoveRight;
                @AnyKey.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAnyKey;
                @AnyKey.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAnyKey;
                @AnyKey.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnAnyKey;
                @Pause.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MagnetNeg.started += instance.OnMagnetNeg;
                @MagnetNeg.performed += instance.OnMagnetNeg;
                @MagnetNeg.canceled += instance.OnMagnetNeg;
                @MagnetPos.started += instance.OnMagnetPos;
                @MagnetPos.performed += instance.OnMagnetPos;
                @MagnetPos.canceled += instance.OnMagnetPos;
                @MoveUp.started += instance.OnMoveUp;
                @MoveUp.performed += instance.OnMoveUp;
                @MoveUp.canceled += instance.OnMoveUp;
                @MoveDown.started += instance.OnMoveDown;
                @MoveDown.performed += instance.OnMoveDown;
                @MoveDown.canceled += instance.OnMoveDown;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @AnyKey.started += instance.OnAnyKey;
                @AnyKey.performed += instance.OnAnyKey;
                @AnyKey.canceled += instance.OnAnyKey;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    private int m_MobileSchemeIndex = -1;
    public InputControlScheme MobileScheme
    {
        get
        {
            if (m_MobileSchemeIndex == -1) m_MobileSchemeIndex = asset.FindControlSchemeIndex("Mobile");
            return asset.controlSchemes[m_MobileSchemeIndex];
        }
    }
    public interface IDefaultActions
    {
        void OnMagnetNeg(InputAction.CallbackContext context);
        void OnMagnetPos(InputAction.CallbackContext context);
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnAnyKey(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
