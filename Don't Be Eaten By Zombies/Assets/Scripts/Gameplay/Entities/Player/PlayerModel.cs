using Gameplay.Entities.Common.Aim;
using Gameplay.Entities.Common.Health;
using Gameplay.Entities.Common.Movement;
using UnityEngine;

namespace Gameplay.Entities.Player
{
    public class PlayerModel : MonoBehaviour, IMovementModel, IAimModel, IHealthModel
    {
        [Header("Player Model")]

        [Header("References")]
        [SerializeField] private Rigidbody2D playerRigidbody2D;
        [SerializeField] private Transform playerTransform;

        [Header("Settings")]
        [SerializeField] private MovementSettings movementSettings;

        //Movement
        public void MoveTowards(Vector2 movementDirection)
        {
            //Only use forward speed for testing
            playerRigidbody2D.velocity = movementSettings.ForwardSpeed * movementDirection;
        }

        public void StopMovement()
        {
            playerRigidbody2D.velocity = Vector2.zero;
        }

        //Aiming
        public void AimTowards(Vector2 aimDirection)
        {
            playerTransform.right = aimDirection;
        }

    }
}