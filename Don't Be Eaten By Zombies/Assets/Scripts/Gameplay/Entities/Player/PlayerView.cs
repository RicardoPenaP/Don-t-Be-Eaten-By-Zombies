using Gameplay.Entities.Common.Movement;
using Gameplay.Input;
using System;
using UnityEngine;

namespace Gameplay.Entities.Player
{
    public class PlayerView : MonoBehaviour, IMovementView
    {
        [Header("Player View")]
        [Header("References")]
        [SerializeField] private InputReader inputReader;

        public event Action<Vector2> OnMoveInputDetected;

        private void Awake()
        {
            inputReader.OnMoveInputUpdated += InputReader_OnMoveInputUpdated;
        }

        private void OnDestroy()
        {
            inputReader.OnMoveInputUpdated -= InputReader_OnMoveInputUpdated;
        }


        private void InputReader_OnMoveInputUpdated(Vector2 rawMovementInput)
        {
            OnMoveInputDetected?.Invoke(rawMovementInput);
        }
    }
}