//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Gameplay/InputReader/Controls.inputactions
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

namespace Gameplay.InputReader
{
    public partial class @Controls: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""MouseAndKeyboard"",
            ""id"": ""56ad8d8a-cfe8-4526-9185-ca9654a10afc"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""702988b9-970a-4326-8360-0d5c46fc1626"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9f27e63e-3aff-4464-a620-370f09336ebd"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TouchScreen"",
            ""id"": ""acec014f-d7d7-425f-97b1-b25028e8e02c"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""569eadfd-9b6d-40b5-8df7-36f8ae6dc134"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f65b35ef-2c80-4bc1-b20c-39200b8a0ec4"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // MouseAndKeyboard
            m_MouseAndKeyboard = asset.FindActionMap("MouseAndKeyboard", throwIfNotFound: true);
            m_MouseAndKeyboard_Newaction = m_MouseAndKeyboard.FindAction("New action", throwIfNotFound: true);
            // TouchScreen
            m_TouchScreen = asset.FindActionMap("TouchScreen", throwIfNotFound: true);
            m_TouchScreen_Newaction = m_TouchScreen.FindAction("New action", throwIfNotFound: true);
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

        // MouseAndKeyboard
        private readonly InputActionMap m_MouseAndKeyboard;
        private List<IMouseAndKeyboardActions> m_MouseAndKeyboardActionsCallbackInterfaces = new List<IMouseAndKeyboardActions>();
        private readonly InputAction m_MouseAndKeyboard_Newaction;
        public struct MouseAndKeyboardActions
        {
            private @Controls m_Wrapper;
            public MouseAndKeyboardActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_MouseAndKeyboard_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_MouseAndKeyboard; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MouseAndKeyboardActions set) { return set.Get(); }
            public void AddCallbacks(IMouseAndKeyboardActions instance)
            {
                if (instance == null || m_Wrapper.m_MouseAndKeyboardActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_MouseAndKeyboardActionsCallbackInterfaces.Add(instance);
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }

            private void UnregisterCallbacks(IMouseAndKeyboardActions instance)
            {
                @Newaction.started -= instance.OnNewaction;
                @Newaction.performed -= instance.OnNewaction;
                @Newaction.canceled -= instance.OnNewaction;
            }

            public void RemoveCallbacks(IMouseAndKeyboardActions instance)
            {
                if (m_Wrapper.m_MouseAndKeyboardActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IMouseAndKeyboardActions instance)
            {
                foreach (var item in m_Wrapper.m_MouseAndKeyboardActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_MouseAndKeyboardActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public MouseAndKeyboardActions @MouseAndKeyboard => new MouseAndKeyboardActions(this);

        // TouchScreen
        private readonly InputActionMap m_TouchScreen;
        private List<ITouchScreenActions> m_TouchScreenActionsCallbackInterfaces = new List<ITouchScreenActions>();
        private readonly InputAction m_TouchScreen_Newaction;
        public struct TouchScreenActions
        {
            private @Controls m_Wrapper;
            public TouchScreenActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_TouchScreen_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_TouchScreen; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TouchScreenActions set) { return set.Get(); }
            public void AddCallbacks(ITouchScreenActions instance)
            {
                if (instance == null || m_Wrapper.m_TouchScreenActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_TouchScreenActionsCallbackInterfaces.Add(instance);
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }

            private void UnregisterCallbacks(ITouchScreenActions instance)
            {
                @Newaction.started -= instance.OnNewaction;
                @Newaction.performed -= instance.OnNewaction;
                @Newaction.canceled -= instance.OnNewaction;
            }

            public void RemoveCallbacks(ITouchScreenActions instance)
            {
                if (m_Wrapper.m_TouchScreenActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ITouchScreenActions instance)
            {
                foreach (var item in m_Wrapper.m_TouchScreenActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_TouchScreenActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public TouchScreenActions @TouchScreen => new TouchScreenActions(this);
        public interface IMouseAndKeyboardActions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
        public interface ITouchScreenActions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
    }
}
