//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Controls.inputactions
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

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""InGame"",
            ""id"": ""af89a6d8-06a9-43a6-8ef1-54a218216a33"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""daca5b6c-a432-412b-84d0-1ecdf8ddc1df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1967f6f9-435c-4d29-a64f-37ec2082a944"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Weapon1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4c1d5ffc-cc9d-4139-ad89-3c8a1c53ef8b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Weapon2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ce5bb327-b34b-4c5b-8483-e17ecf72445c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Weapon3"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f68fca56-8a0e-4cf1-a62d-1115fd5e2659"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Weapon4"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5b4a701d-f73f-4f38-a4dd-befc5b6154e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6795d53b-4c77-4c2a-996f-1b08db15dd57"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88c0be56-bdd3-491d-9d6d-0f2be67ea57f"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a5b1dc3-e5c9-4667-bdce-ce115974e71c"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84ed5cbb-e2e5-44e9-9534-a1276a91e6ee"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6667e8db-93e0-4d1b-8c43-91e2af060e72"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23a57990-0d1d-4ae2-96b8-f169fa5d0080"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Weapon4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Permenanet"",
            ""id"": ""8a05f712-4fac-43bf-82ab-5cb828d08c7b"",
            ""actions"": [
                {
                    ""name"": ""MousePos"",
                    ""type"": ""PassThrough"",
                    ""id"": ""60539386-db1f-4c0d-81f0-651d7745845d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""29d64221-5988-4e23-8285-35d1a567aa09"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_Shoot = m_InGame.FindAction("Shoot", throwIfNotFound: true);
        m_InGame_Reload = m_InGame.FindAction("Reload", throwIfNotFound: true);
        m_InGame_Weapon1 = m_InGame.FindAction("Weapon1", throwIfNotFound: true);
        m_InGame_Weapon2 = m_InGame.FindAction("Weapon2", throwIfNotFound: true);
        m_InGame_Weapon3 = m_InGame.FindAction("Weapon3", throwIfNotFound: true);
        m_InGame_Weapon4 = m_InGame.FindAction("Weapon4", throwIfNotFound: true);
        // Permenanet
        m_Permenanet = asset.FindActionMap("Permenanet", throwIfNotFound: true);
        m_Permenanet_MousePos = m_Permenanet.FindAction("MousePos", throwIfNotFound: true);
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

    // InGame
    private readonly InputActionMap m_InGame;
    private List<IInGameActions> m_InGameActionsCallbackInterfaces = new List<IInGameActions>();
    private readonly InputAction m_InGame_Shoot;
    private readonly InputAction m_InGame_Reload;
    private readonly InputAction m_InGame_Weapon1;
    private readonly InputAction m_InGame_Weapon2;
    private readonly InputAction m_InGame_Weapon3;
    private readonly InputAction m_InGame_Weapon4;
    public struct InGameActions
    {
        private @Controls m_Wrapper;
        public InGameActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_InGame_Shoot;
        public InputAction @Reload => m_Wrapper.m_InGame_Reload;
        public InputAction @Weapon1 => m_Wrapper.m_InGame_Weapon1;
        public InputAction @Weapon2 => m_Wrapper.m_InGame_Weapon2;
        public InputAction @Weapon3 => m_Wrapper.m_InGame_Weapon3;
        public InputAction @Weapon4 => m_Wrapper.m_InGame_Weapon4;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void AddCallbacks(IInGameActions instance)
        {
            if (instance == null || m_Wrapper.m_InGameActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InGameActionsCallbackInterfaces.Add(instance);
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Reload.started += instance.OnReload;
            @Reload.performed += instance.OnReload;
            @Reload.canceled += instance.OnReload;
            @Weapon1.started += instance.OnWeapon1;
            @Weapon1.performed += instance.OnWeapon1;
            @Weapon1.canceled += instance.OnWeapon1;
            @Weapon2.started += instance.OnWeapon2;
            @Weapon2.performed += instance.OnWeapon2;
            @Weapon2.canceled += instance.OnWeapon2;
            @Weapon3.started += instance.OnWeapon3;
            @Weapon3.performed += instance.OnWeapon3;
            @Weapon3.canceled += instance.OnWeapon3;
            @Weapon4.started += instance.OnWeapon4;
            @Weapon4.performed += instance.OnWeapon4;
            @Weapon4.canceled += instance.OnWeapon4;
        }

        private void UnregisterCallbacks(IInGameActions instance)
        {
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Reload.started -= instance.OnReload;
            @Reload.performed -= instance.OnReload;
            @Reload.canceled -= instance.OnReload;
            @Weapon1.started -= instance.OnWeapon1;
            @Weapon1.performed -= instance.OnWeapon1;
            @Weapon1.canceled -= instance.OnWeapon1;
            @Weapon2.started -= instance.OnWeapon2;
            @Weapon2.performed -= instance.OnWeapon2;
            @Weapon2.canceled -= instance.OnWeapon2;
            @Weapon3.started -= instance.OnWeapon3;
            @Weapon3.performed -= instance.OnWeapon3;
            @Weapon3.canceled -= instance.OnWeapon3;
            @Weapon4.started -= instance.OnWeapon4;
            @Weapon4.performed -= instance.OnWeapon4;
            @Weapon4.canceled -= instance.OnWeapon4;
        }

        public void RemoveCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInGameActions instance)
        {
            foreach (var item in m_Wrapper.m_InGameActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InGameActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InGameActions @InGame => new InGameActions(this);

    // Permenanet
    private readonly InputActionMap m_Permenanet;
    private List<IPermenanetActions> m_PermenanetActionsCallbackInterfaces = new List<IPermenanetActions>();
    private readonly InputAction m_Permenanet_MousePos;
    public struct PermenanetActions
    {
        private @Controls m_Wrapper;
        public PermenanetActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePos => m_Wrapper.m_Permenanet_MousePos;
        public InputActionMap Get() { return m_Wrapper.m_Permenanet; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PermenanetActions set) { return set.Get(); }
        public void AddCallbacks(IPermenanetActions instance)
        {
            if (instance == null || m_Wrapper.m_PermenanetActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PermenanetActionsCallbackInterfaces.Add(instance);
            @MousePos.started += instance.OnMousePos;
            @MousePos.performed += instance.OnMousePos;
            @MousePos.canceled += instance.OnMousePos;
        }

        private void UnregisterCallbacks(IPermenanetActions instance)
        {
            @MousePos.started -= instance.OnMousePos;
            @MousePos.performed -= instance.OnMousePos;
            @MousePos.canceled -= instance.OnMousePos;
        }

        public void RemoveCallbacks(IPermenanetActions instance)
        {
            if (m_Wrapper.m_PermenanetActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPermenanetActions instance)
        {
            foreach (var item in m_Wrapper.m_PermenanetActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PermenanetActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PermenanetActions @Permenanet => new PermenanetActions(this);
    public interface IInGameActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnWeapon1(InputAction.CallbackContext context);
        void OnWeapon2(InputAction.CallbackContext context);
        void OnWeapon3(InputAction.CallbackContext context);
        void OnWeapon4(InputAction.CallbackContext context);
    }
    public interface IPermenanetActions
    {
        void OnMousePos(InputAction.CallbackContext context);
    }
}
