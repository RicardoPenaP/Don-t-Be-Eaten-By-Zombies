using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static Gameplay.Input.Controls;

namespace Gameplay.Input
{
    [CreateAssetMenu(menuName = "Gameplay/Input/Input Reader", fileName = "NewInputReader")]
    public class InputReader : ScriptableObject, IPlayerActions
    {
        [Header("Input Reader")]
        [SerializeField, Range(0f, 1f)] private float attackInputDeathzone = 0.6f;

        public event Action<Vector2> OnAimInputUpdated;
        public event Action<bool> OnAttackInputUpdated;
        public event Action OnChangeWeaponInputUpdated;
        public event Action<Vector2> OnMoveInputUpdated;
        public event Action OnReloadInputUpdated;

        private Controls controls;

        private Vector2 aimRawInput;
        public Vector2 AimRawInput => aimRawInput;

        private void OnEnable()
        {
            Init();
        }

        private void Init()
        {
            if (controls is not null)
            {
                return;
            }
            controls = new Controls();
            controls.Player.SetCallbacks(this);
            controls.Player.Enable();
        }

        public void OnAim(InputAction.CallbackContext context)
        {
            aimRawInput = context.ReadValue<Vector2>();
            OnAimInputUpdated?.Invoke(aimRawInput);
        }

        public void OnAttack(InputAction.CallbackContext context)
        {
#if UNITY_ANDROID         
            Vector2 rawInput = context.ReadValue<Vector2>();
            OnAttackInputUpdated?.Invoke(rawInput.magnitude >= attackInputDeathzone);
#endif
        }

        public void OnChangeWeapon(InputAction.CallbackContext context)
        {
            OnChangeWeaponInputUpdated?.Invoke();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            Vector2 rawMoveInput = context.ReadValue<Vector2>();
            OnMoveInputUpdated?.Invoke(rawMoveInput);
        }

        public void OnReload(InputAction.CallbackContext context)
        {
            OnReloadInputUpdated?.Invoke();
        }

    }
}
