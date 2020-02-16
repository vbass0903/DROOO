// GENERATED AUTOMATICALLY FROM 'Assets/P2ControllerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @P2ControllerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @P2ControllerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""P2ControllerActions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""9538554f-b766-4ed0-a381-958eeda7fc1c"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9be37d22-4d77-4ca4-bd9f-04b4a42ad4e4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attach"",
                    ""type"": ""Button"",
                    ""id"": ""9eef240f-d291-47ee-a00f-dcbb8251a73f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Detach"",
                    ""type"": ""Button"",
                    ""id"": ""51d855a5-bf33-4fc3-bc85-27a26ca9eb65"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TurretFire"",
                    ""type"": ""Button"",
                    ""id"": ""5e172e74-ca74-4891-a318-e759c6decd98"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveL"",
                    ""type"": ""Button"",
                    ""id"": ""54aac522-fcd5-4125-9370-9b0db056072d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveR"",
                    ""type"": ""Button"",
                    ""id"": ""3c79e0a5-28a5-41b2-9dd1-97a93d3b539c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""29bbb99c-6cb7-4ac4-9a8c-fe77110698d9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63e5c4ad-4928-42fb-a441-6b4888318778"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attach"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88b42bc0-6cea-4975-9470-6caf4cc3c5a6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Detach"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab78b43e-f9c2-4eeb-87a0-15818e803c51"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurretFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f08b2bb0-302d-481e-8bd1-2e9689eff967"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50a09c74-c1c5-488b-97c5-2e91381ae001"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_Attach = m_Gameplay.FindAction("Attach", throwIfNotFound: true);
        m_Gameplay_Detach = m_Gameplay.FindAction("Detach", throwIfNotFound: true);
        m_Gameplay_TurretFire = m_Gameplay.FindAction("TurretFire", throwIfNotFound: true);
        m_Gameplay_MoveL = m_Gameplay.FindAction("MoveL", throwIfNotFound: true);
        m_Gameplay_MoveR = m_Gameplay.FindAction("MoveR", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_Attach;
    private readonly InputAction m_Gameplay_Detach;
    private readonly InputAction m_Gameplay_TurretFire;
    private readonly InputAction m_Gameplay_MoveL;
    private readonly InputAction m_Gameplay_MoveR;
    public struct GameplayActions
    {
        private @P2ControllerActions m_Wrapper;
        public GameplayActions(@P2ControllerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @Attach => m_Wrapper.m_Gameplay_Attach;
        public InputAction @Detach => m_Wrapper.m_Gameplay_Detach;
        public InputAction @TurretFire => m_Wrapper.m_Gameplay_TurretFire;
        public InputAction @MoveL => m_Wrapper.m_Gameplay_MoveL;
        public InputAction @MoveR => m_Wrapper.m_Gameplay_MoveR;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Attach.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttach;
                @Attach.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttach;
                @Attach.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttach;
                @Detach.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDetach;
                @Detach.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDetach;
                @Detach.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDetach;
                @TurretFire.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurretFire;
                @TurretFire.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurretFire;
                @TurretFire.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurretFire;
                @MoveL.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveL;
                @MoveL.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveL;
                @MoveL.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveL;
                @MoveR.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveR;
                @MoveR.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveR;
                @MoveR.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveR;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Attach.started += instance.OnAttach;
                @Attach.performed += instance.OnAttach;
                @Attach.canceled += instance.OnAttach;
                @Detach.started += instance.OnDetach;
                @Detach.performed += instance.OnDetach;
                @Detach.canceled += instance.OnDetach;
                @TurretFire.started += instance.OnTurretFire;
                @TurretFire.performed += instance.OnTurretFire;
                @TurretFire.canceled += instance.OnTurretFire;
                @MoveL.started += instance.OnMoveL;
                @MoveL.performed += instance.OnMoveL;
                @MoveL.canceled += instance.OnMoveL;
                @MoveR.started += instance.OnMoveR;
                @MoveR.performed += instance.OnMoveR;
                @MoveR.canceled += instance.OnMoveR;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnAttach(InputAction.CallbackContext context);
        void OnDetach(InputAction.CallbackContext context);
        void OnTurretFire(InputAction.CallbackContext context);
        void OnMoveL(InputAction.CallbackContext context);
        void OnMoveR(InputAction.CallbackContext context);
    }
}
