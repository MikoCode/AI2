//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Input/InputSeeker.inputactions
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

public partial class @InputSeeker: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSeeker()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSeeker"",
    ""maps"": [
        {
            ""name"": ""MapaAkcji"",
            ""id"": ""0fb07698-42e4-4321-bbe0-725b96139b85"",
            ""actions"": [
                {
                    ""name"": ""Akcja"",
                    ""type"": ""Button"",
                    ""id"": ""c961177a-8fe4-44e7-b024-7b1bc1278bf8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""306d2595-ee08-4164-902a-a34989192086"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Akcja"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MapaAkcji
        m_MapaAkcji = asset.FindActionMap("MapaAkcji", throwIfNotFound: true);
        m_MapaAkcji_Akcja = m_MapaAkcji.FindAction("Akcja", throwIfNotFound: true);
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

    // MapaAkcji
    private readonly InputActionMap m_MapaAkcji;
    private List<IMapaAkcjiActions> m_MapaAkcjiActionsCallbackInterfaces = new List<IMapaAkcjiActions>();
    private readonly InputAction m_MapaAkcji_Akcja;
    public struct MapaAkcjiActions
    {
        private @InputSeeker m_Wrapper;
        public MapaAkcjiActions(@InputSeeker wrapper) { m_Wrapper = wrapper; }
        public InputAction @Akcja => m_Wrapper.m_MapaAkcji_Akcja;
        public InputActionMap Get() { return m_Wrapper.m_MapaAkcji; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MapaAkcjiActions set) { return set.Get(); }
        public void AddCallbacks(IMapaAkcjiActions instance)
        {
            if (instance == null || m_Wrapper.m_MapaAkcjiActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MapaAkcjiActionsCallbackInterfaces.Add(instance);
            @Akcja.started += instance.OnAkcja;
            @Akcja.performed += instance.OnAkcja;
            @Akcja.canceled += instance.OnAkcja;
        }

        private void UnregisterCallbacks(IMapaAkcjiActions instance)
        {
            @Akcja.started -= instance.OnAkcja;
            @Akcja.performed -= instance.OnAkcja;
            @Akcja.canceled -= instance.OnAkcja;
        }

        public void RemoveCallbacks(IMapaAkcjiActions instance)
        {
            if (m_Wrapper.m_MapaAkcjiActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMapaAkcjiActions instance)
        {
            foreach (var item in m_Wrapper.m_MapaAkcjiActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MapaAkcjiActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MapaAkcjiActions @MapaAkcji => new MapaAkcjiActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IMapaAkcjiActions
    {
        void OnAkcja(InputAction.CallbackContext context);
    }
}
