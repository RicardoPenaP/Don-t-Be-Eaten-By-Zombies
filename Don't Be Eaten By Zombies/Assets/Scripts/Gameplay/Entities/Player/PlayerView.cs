using Gameplay.Entities.Common.Aim;
using Gameplay.Entities.Common.Health;
using Gameplay.Entities.Common.Movement;
using Gameplay.Entities.Common.WeaponActions;
using Gameplay.Input;
using System;
using UnityEngine;

namespace Gameplay.Entities.Player
{
    public class PlayerView : MonoBehaviour, IMovementView, IAimView, IHealthView, IWeaponActionsView
    {
        [Header("Player View")]
        [Header("References")]
        [SerializeField] private InputReader inputReader;
        [SerializeField] private HealthCanvas healthCanvas;

        public event Action<Vector2> OnMoveInputDetected;
        public event Action<Vector2> OnAimInputDetected;
        public event Action OnAttackInputDetected;
        public event Action OnReloadInputDetected;

        public bool isAttacking = false;

        private void Awake()
        {
            Init();
        }

        private void Update()
        {
            if (isAttacking)
            {
                OnAttackInputDetected?.Invoke();
            }
        }

        private void OnDestroy()
        {
            Deinit();
        }

        private void Init()
        {
            inputReader.OnMoveInputUpdated += InputReader_OnMoveInputUpdated;
            inputReader.OnAimInputUpdated += InputReader_OnAimInputUpdated;
            inputReader.OnAttackInputUpdated += state => isAttacking = state;
            inputReader.OnReloadInputUpdated += () => OnReloadInputDetected?.Invoke();
        }

        private void Deinit()
        {
            inputReader.OnMoveInputUpdated -= InputReader_OnMoveInputUpdated;
            inputReader.OnAimInputUpdated -= InputReader_OnAimInputUpdated;
            inputReader.OnAttackInputUpdated -= state => isAttacking = state;
            inputReader.OnReloadInputUpdated -= () => OnReloadInputDetected?.Invoke();
        }

        private void InputReader_OnMoveInputUpdated(Vector2 rawMovementInput)
        {
            OnMoveInputDetected?.Invoke(rawMovementInput);
        }

        private void InputReader_OnAimInputUpdated(Vector2 rawAimInput)
        {
            OnAimInputDetected?.Invoke(rawAimInput);
        }

        //Health
        public void UpdateHealthBar(float normalizedCurrentHealth)
        {
            healthCanvas.UpdateHealthBar(normalizedCurrentHealth);
        }
    }
}