// GENERATED AUTOMATICALLY FROM 'Packages/com.ekaka.core/Runtime/Input/BaseInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Core.Input
{
    public class @BaseInputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @BaseInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""BaseInputActions"",
    ""maps"": [
        {
            ""name"": ""Foot"",
            ""id"": ""a4da1d15-e694-4e73-8a85-dfea850ad910"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""598bcfac-f24b-4774-bb63-202be2534809"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Walk"",
                    ""type"": ""Button"",
                    ""id"": ""0eebf7a7-8109-4853-80eb-9976f9520472"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""15c2da28-9e9f-420d-9bd2-103e2addffc7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""97f7efd8-ec59-4ba8-a7ce-a190f59bbb1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""2782cdc1-76f9-43a6-9371-59f7529232f1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7642bc4c-1a03-446b-8adf-ac12d79bf68b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""044ffad0-1b62-4cca-b2fc-2d463c7e3712"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e355a9c9-6a45-4f80-8cb0-46d4ca0a67f2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""28218cb3-b6cd-4fdc-8ff0-d351e8ce6d39"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f0a6ce18-c9e9-48cb-98c7-958207fc016b"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fcc975a0-91e8-4d31-8b71-9387dcaa7455"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64f9c63a-6817-401e-b7c5-09fc9f93daec"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""View"",
            ""id"": ""49bb0ee8-15d7-41c5-aa61-2d7639fbeb07"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""359cd185-7ce9-411f-8611-f746942b648d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""555552db-7c63-4e17-b325-25583fe901c8"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Foot
            m_Foot = asset.FindActionMap("Foot", throwIfNotFound: true);
            m_Foot_Move = m_Foot.FindAction("Move", throwIfNotFound: true);
            m_Foot_Walk = m_Foot.FindAction("Walk", throwIfNotFound: true);
            m_Foot_Sprint = m_Foot.FindAction("Sprint", throwIfNotFound: true);
            m_Foot_Jump = m_Foot.FindAction("Jump", throwIfNotFound: true);
            // View
            m_View = asset.FindActionMap("View", throwIfNotFound: true);
            m_View_Look = m_View.FindAction("Look", throwIfNotFound: true);
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

        // Foot
        private readonly InputActionMap m_Foot;
        private IFootActions m_FootActionsCallbackInterface;
        private readonly InputAction m_Foot_Move;
        private readonly InputAction m_Foot_Walk;
        private readonly InputAction m_Foot_Sprint;
        private readonly InputAction m_Foot_Jump;
        public struct FootActions
        {
            private @BaseInputActions m_Wrapper;
            public FootActions(@BaseInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Foot_Move;
            public InputAction @Walk => m_Wrapper.m_Foot_Walk;
            public InputAction @Sprint => m_Wrapper.m_Foot_Sprint;
            public InputAction @Jump => m_Wrapper.m_Foot_Jump;
            public InputActionMap Get() { return m_Wrapper.m_Foot; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(FootActions set) { return set.Get(); }
            public void SetCallbacks(IFootActions instance)
            {
                if (m_Wrapper.m_FootActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_FootActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_FootActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_FootActionsCallbackInterface.OnMove;
                    @Walk.started -= m_Wrapper.m_FootActionsCallbackInterface.OnWalk;
                    @Walk.performed -= m_Wrapper.m_FootActionsCallbackInterface.OnWalk;
                    @Walk.canceled -= m_Wrapper.m_FootActionsCallbackInterface.OnWalk;
                    @Sprint.started -= m_Wrapper.m_FootActionsCallbackInterface.OnSprint;
                    @Sprint.performed -= m_Wrapper.m_FootActionsCallbackInterface.OnSprint;
                    @Sprint.canceled -= m_Wrapper.m_FootActionsCallbackInterface.OnSprint;
                    @Jump.started -= m_Wrapper.m_FootActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_FootActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_FootActionsCallbackInterface.OnJump;
                }
                m_Wrapper.m_FootActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Walk.started += instance.OnWalk;
                    @Walk.performed += instance.OnWalk;
                    @Walk.canceled += instance.OnWalk;
                    @Sprint.started += instance.OnSprint;
                    @Sprint.performed += instance.OnSprint;
                    @Sprint.canceled += instance.OnSprint;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                }
            }
        }
        public FootActions @Foot => new FootActions(this);

        // View
        private readonly InputActionMap m_View;
        private IViewActions m_ViewActionsCallbackInterface;
        private readonly InputAction m_View_Look;
        public struct ViewActions
        {
            private @BaseInputActions m_Wrapper;
            public ViewActions(@BaseInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Look => m_Wrapper.m_View_Look;
            public InputActionMap Get() { return m_Wrapper.m_View; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(ViewActions set) { return set.Get(); }
            public void SetCallbacks(IViewActions instance)
            {
                if (m_Wrapper.m_ViewActionsCallbackInterface != null)
                {
                    @Look.started -= m_Wrapper.m_ViewActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_ViewActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_ViewActionsCallbackInterface.OnLook;
                }
                m_Wrapper.m_ViewActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                }
            }
        }
        public ViewActions @View => new ViewActions(this);
        public interface IFootActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnWalk(InputAction.CallbackContext context);
            void OnSprint(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
        }
        public interface IViewActions
        {
            void OnLook(InputAction.CallbackContext context);
        }
    }
}
