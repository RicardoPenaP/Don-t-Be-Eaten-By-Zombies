using Gameplay.Entities.Common.Aim;
using Gameplay.Entities.Common.Health;
using Gameplay.Entities.Common.Movement;
using Gameplay.Input;
using System;
using UnityEngine;

namespace Gameplay.Entities.Player
{
    public class PlayerView : MonoBehaviour, IMovementView, IAimView, IHealthView
    {
        [Header("Player View")]
        [Header("References")]
        [SerializeField] private InputReader inputReader;

        public event Action<Vector2> OnMoveInputDetected;
        public event Action<Vector2> OnAimInputDetected;

        private void Awake()
        {
            inputReader.OnMoveInputUpdated += InputReader_OnMoveInputUpdated;
            inputReader.OnAimInputUpdated += InputReader_OnAimInputUpdated;
        }

        private void OnDestroy()
        {
            inputReader.OnMoveInputUpdated -= InputReader_OnMoveInputUpdated;
            inputReader.OnAimInputUpdated += InputReader_OnAimInputUpdated;
        }

        private void InputReader_OnMoveInputUpdated(Vector2 rawMovementInput)
        {
            OnMoveInputDetected?.Invoke(rawMovementInput);
        }

        private void InputReader_OnAimInputUpdated(Vector2 rawAimInput)
        {
            OnAimInputDetected?.Invoke(rawAimInput);
        }

    }
}