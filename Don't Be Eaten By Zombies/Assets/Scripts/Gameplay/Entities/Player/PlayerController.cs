using Gameplay.Entities.Common.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay.Entities.Player
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Player Controller")]
        [Header("References")]
        [SerializeField] private PlayerView playerView;
        [SerializeField] private PlayerModel playerModel;

        private MovementController movementController;

        private void Awake()
        {
            movementController = new MovementController(playerView, playerModel);
        }

        private void OnDestroy()
        {
            movementController.Dispose();
        }
    }
}
