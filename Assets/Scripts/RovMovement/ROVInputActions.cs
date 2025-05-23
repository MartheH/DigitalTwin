//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.13.1
//     from Assets/Scripts/RovMovement/ROVInputActions.inputactions
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

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/Scripts/RovMovement/ROVInputActions.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @ROVInputActions: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @ROVInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ROVInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""c6b38c1e-bb76-4235-878c-b0921f94a89e"",
            ""actions"": [
                {
                    ""name"": ""LeftRightUpDownMove"",
                    ""type"": ""Value"",
                    ""id"": ""25fb2960-b139-47fa-b839-666060b5b685"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""00c3754b-56f0-4f7d-ae18-ba3bbce64143"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""6177cf68-f083-46e1-82cf-4b65ff6ca49d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ForwardBackwardMove"",
                    ""type"": ""Button"",
                    ""id"": ""0845537c-ee35-4011-b227-8132761dc29c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CameraPitch"",
                    ""type"": ""Value"",
                    ""id"": ""65e7cde5-093c-4aec-8d4e-396116beaa65"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Local/remote"",
                    ""type"": ""Button"",
                    ""id"": ""9e9f2443-b8ae-4450-8527-9a0b690fb50c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cbc4ed12-471c-4c7e-b3cf-fbcf414a239b"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightUpDownMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""eddc359f-9b9b-4542-8a04-1634a0a68ee3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightUpDownMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ff0717de-d24b-42d9-ad61-533b810b6ff1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightUpDownMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b32f66a3-c315-4ed6-94f5-ae20873fafb5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightUpDownMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b1b1db62-d39a-4e20-8ef2-952997598ec7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightUpDownMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a767dd79-3327-4f8e-bdfe-7eafbdfc7816"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightUpDownMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""2e144625-3b84-475a-98e4-3fa22799c536"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f5bafbc5-f703-4332-ab92-9a8d75c0e0fd"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f118ceb8-f6fb-4509-a7c2-8757f1643923"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f0f68356-8611-4c15-8c22-3ceafcd8f916"",
                    ""path"": ""<XInputController>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c6e06635-3640-4749-bff2-8fa08deca930"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""191fc918-60e6-45aa-9543-f647605f03c0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""9a496e1b-ceca-46bc-a426-d9f81d0840f9"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""af62abb4-c1b4-4295-8a03-c221c5b94c2f"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a6e79207-0b49-4d21-97cd-73d610c42654"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardBackwardMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""23a7883a-dc11-4398-835d-6756f4c8c641"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardBackwardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""544c2fa1-d33a-4460-ac2e-861205669b94"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardBackwardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7f919418-9466-4b6f-afee-f1e005ead0e2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraPitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""183fbc33-44d2-4aef-9cf9-357d6fb632e0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraPitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""49b22e56-1aa3-4ccb-a417-268a06780ecc"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraPitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""651151c8-d431-40ca-b0b2-acff864a4992"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Local/remote"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""StaticCamera"",
            ""id"": ""3a71b6f9-ffd2-4ebf-8c03-fe3ff6fe69cb"",
            ""actions"": [
                {
                    ""name"": ""CameraLook"",
                    ""type"": ""Value"",
                    ""id"": ""ec7e758d-739d-41c8-b25c-6285419f82cc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c9a08246-8529-4729-b3b9-371d80a0681d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_LeftRightUpDownMove = m_Player.FindAction("LeftRightUpDownMove", throwIfNotFound: true);
        m_Player_Rotation = m_Player.FindAction("Rotation", throwIfNotFound: true);
        m_Player_Vertical = m_Player.FindAction("Vertical", throwIfNotFound: true);
        m_Player_ForwardBackwardMove = m_Player.FindAction("ForwardBackwardMove", throwIfNotFound: true);
        m_Player_CameraPitch = m_Player.FindAction("CameraPitch", throwIfNotFound: true);
        m_Player_Localremote = m_Player.FindAction("Local/remote", throwIfNotFound: true);
        // StaticCamera
        m_StaticCamera = asset.FindActionMap("StaticCamera", throwIfNotFound: true);
        m_StaticCamera_CameraLook = m_StaticCamera.FindAction("CameraLook", throwIfNotFound: true);
    }

    ~@ROVInputActions()
    {
        UnityEngine.Debug.Assert(!m_Player.enabled, "This will cause a leak and performance issues, ROVInputActions.Player.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_StaticCamera.enabled, "This will cause a leak and performance issues, ROVInputActions.StaticCamera.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_LeftRightUpDownMove;
    private readonly InputAction m_Player_Rotation;
    private readonly InputAction m_Player_Vertical;
    private readonly InputAction m_Player_ForwardBackwardMove;
    private readonly InputAction m_Player_CameraPitch;
    private readonly InputAction m_Player_Localremote;
    /// <summary>
    /// Provides access to input actions defined in input action map "Player".
    /// </summary>
    public struct PlayerActions
    {
        private @ROVInputActions m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public PlayerActions(@ROVInputActions wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "Player/LeftRightUpDownMove".
        /// </summary>
        public InputAction @LeftRightUpDownMove => m_Wrapper.m_Player_LeftRightUpDownMove;
        /// <summary>
        /// Provides access to the underlying input action "Player/Rotation".
        /// </summary>
        public InputAction @Rotation => m_Wrapper.m_Player_Rotation;
        /// <summary>
        /// Provides access to the underlying input action "Player/Vertical".
        /// </summary>
        public InputAction @Vertical => m_Wrapper.m_Player_Vertical;
        /// <summary>
        /// Provides access to the underlying input action "Player/ForwardBackwardMove".
        /// </summary>
        public InputAction @ForwardBackwardMove => m_Wrapper.m_Player_ForwardBackwardMove;
        /// <summary>
        /// Provides access to the underlying input action "Player/CameraPitch".
        /// </summary>
        public InputAction @CameraPitch => m_Wrapper.m_Player_CameraPitch;
        /// <summary>
        /// Provides access to the underlying input action "Player/Localremote".
        /// </summary>
        public InputAction @Localremote => m_Wrapper.m_Player_Localremote;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="PlayerActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="PlayerActions" />
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @LeftRightUpDownMove.started += instance.OnLeftRightUpDownMove;
            @LeftRightUpDownMove.performed += instance.OnLeftRightUpDownMove;
            @LeftRightUpDownMove.canceled += instance.OnLeftRightUpDownMove;
            @Rotation.started += instance.OnRotation;
            @Rotation.performed += instance.OnRotation;
            @Rotation.canceled += instance.OnRotation;
            @Vertical.started += instance.OnVertical;
            @Vertical.performed += instance.OnVertical;
            @Vertical.canceled += instance.OnVertical;
            @ForwardBackwardMove.started += instance.OnForwardBackwardMove;
            @ForwardBackwardMove.performed += instance.OnForwardBackwardMove;
            @ForwardBackwardMove.canceled += instance.OnForwardBackwardMove;
            @CameraPitch.started += instance.OnCameraPitch;
            @CameraPitch.performed += instance.OnCameraPitch;
            @CameraPitch.canceled += instance.OnCameraPitch;
            @Localremote.started += instance.OnLocalremote;
            @Localremote.performed += instance.OnLocalremote;
            @Localremote.canceled += instance.OnLocalremote;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="PlayerActions" />
        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @LeftRightUpDownMove.started -= instance.OnLeftRightUpDownMove;
            @LeftRightUpDownMove.performed -= instance.OnLeftRightUpDownMove;
            @LeftRightUpDownMove.canceled -= instance.OnLeftRightUpDownMove;
            @Rotation.started -= instance.OnRotation;
            @Rotation.performed -= instance.OnRotation;
            @Rotation.canceled -= instance.OnRotation;
            @Vertical.started -= instance.OnVertical;
            @Vertical.performed -= instance.OnVertical;
            @Vertical.canceled -= instance.OnVertical;
            @ForwardBackwardMove.started -= instance.OnForwardBackwardMove;
            @ForwardBackwardMove.performed -= instance.OnForwardBackwardMove;
            @ForwardBackwardMove.canceled -= instance.OnForwardBackwardMove;
            @CameraPitch.started -= instance.OnCameraPitch;
            @CameraPitch.performed -= instance.OnCameraPitch;
            @CameraPitch.canceled -= instance.OnCameraPitch;
            @Localremote.started -= instance.OnLocalremote;
            @Localremote.performed -= instance.OnLocalremote;
            @Localremote.canceled -= instance.OnLocalremote;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="PlayerActions.UnregisterCallbacks(IPlayerActions)" />.
        /// </summary>
        /// <seealso cref="PlayerActions.UnregisterCallbacks(IPlayerActions)" />
        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="PlayerActions.AddCallbacks(IPlayerActions)" />
        /// <seealso cref="PlayerActions.RemoveCallbacks(IPlayerActions)" />
        /// <seealso cref="PlayerActions.UnregisterCallbacks(IPlayerActions)" />
        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="PlayerActions" /> instance referencing this action map.
    /// </summary>
    public PlayerActions @Player => new PlayerActions(this);

    // StaticCamera
    private readonly InputActionMap m_StaticCamera;
    private List<IStaticCameraActions> m_StaticCameraActionsCallbackInterfaces = new List<IStaticCameraActions>();
    private readonly InputAction m_StaticCamera_CameraLook;
    /// <summary>
    /// Provides access to input actions defined in input action map "StaticCamera".
    /// </summary>
    public struct StaticCameraActions
    {
        private @ROVInputActions m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public StaticCameraActions(@ROVInputActions wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "StaticCamera/CameraLook".
        /// </summary>
        public InputAction @CameraLook => m_Wrapper.m_StaticCamera_CameraLook;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_StaticCamera; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="StaticCameraActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(StaticCameraActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="StaticCameraActions" />
        public void AddCallbacks(IStaticCameraActions instance)
        {
            if (instance == null || m_Wrapper.m_StaticCameraActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_StaticCameraActionsCallbackInterfaces.Add(instance);
            @CameraLook.started += instance.OnCameraLook;
            @CameraLook.performed += instance.OnCameraLook;
            @CameraLook.canceled += instance.OnCameraLook;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="StaticCameraActions" />
        private void UnregisterCallbacks(IStaticCameraActions instance)
        {
            @CameraLook.started -= instance.OnCameraLook;
            @CameraLook.performed -= instance.OnCameraLook;
            @CameraLook.canceled -= instance.OnCameraLook;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="StaticCameraActions.UnregisterCallbacks(IStaticCameraActions)" />.
        /// </summary>
        /// <seealso cref="StaticCameraActions.UnregisterCallbacks(IStaticCameraActions)" />
        public void RemoveCallbacks(IStaticCameraActions instance)
        {
            if (m_Wrapper.m_StaticCameraActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="StaticCameraActions.AddCallbacks(IStaticCameraActions)" />
        /// <seealso cref="StaticCameraActions.RemoveCallbacks(IStaticCameraActions)" />
        /// <seealso cref="StaticCameraActions.UnregisterCallbacks(IStaticCameraActions)" />
        public void SetCallbacks(IStaticCameraActions instance)
        {
            foreach (var item in m_Wrapper.m_StaticCameraActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_StaticCameraActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="StaticCameraActions" /> instance referencing this action map.
    /// </summary>
    public StaticCameraActions @StaticCamera => new StaticCameraActions(this);
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "Player" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="PlayerActions.AddCallbacks(IPlayerActions)" />
    /// <seealso cref="PlayerActions.RemoveCallbacks(IPlayerActions)" />
    public interface IPlayerActions
    {
        /// <summary>
        /// Method invoked when associated input action "LeftRightUpDownMove" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnLeftRightUpDownMove(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Rotation" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnRotation(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Vertical" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnVertical(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "ForwardBackwardMove" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnForwardBackwardMove(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "CameraPitch" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnCameraPitch(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Local/remote" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnLocalremote(InputAction.CallbackContext context);
    }
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "StaticCamera" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="StaticCameraActions.AddCallbacks(IStaticCameraActions)" />
    /// <seealso cref="StaticCameraActions.RemoveCallbacks(IStaticCameraActions)" />
    public interface IStaticCameraActions
    {
        /// <summary>
        /// Method invoked when associated input action "CameraLook" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnCameraLook(InputAction.CallbackContext context);
    }
}
