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
        [Header("Settings")]
        [SerializeField] private bool attackWithAimStick = true;
        [SerializeField, Range(0f, 1f)] private float aimDeathzoneForAttack;

        public event Action<Vector2> OnAimInputUpdated;
        public event Action<bool> OnAttackInputUpdated;
        public event Action OnChangeWeaponInputUpdated;
        public event Action<Vector2> OnMoveInputUpdated;
        public event Action OnReloadInputUpdated;

        private Controls controls;

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
            Vector2 aimRawInput = context.ReadValue<Vector2>();
            OnAimInputUpdated?.Invoke(aimRawInput);

            if (!attackWithAimStick)
            {
                return;
            }
            OnAttackInputUpdated?.Invoke(aimRawInput.magnitude >= aimDeathzoneForAttack);            
        }

        public void OnAttack(InputAction.CallbackContext context)
        {
            bool state = false;
            switch (context.phase)
            {
                case InputActionPhase.Performed:
                    state = true;
                    break;
                case InputActionPhase.Canceled:
                    state = false;
                    break;
                default:
                    break;
            }
            OnAttackInputUpdated?.Invoke(state);
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
