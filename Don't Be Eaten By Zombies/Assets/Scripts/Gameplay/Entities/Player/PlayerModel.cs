using Gameplay.Entities.Common.Movement;
using UnityEngine;

namespace Gameplay.Entities.Player
{
    public class PlayerModel : MonoBehaviour, IMovementModel
    {
        [Header("Player Model")]

        [Header("References")]
        [SerializeField] private Rigidbody2D playerRigidbody2D;

        [Header("Settings")]
        [SerializeField] private MovementSettings movementSettings;

        public void MoveTowards(Vector2 movementDirection)
        {
            //Only use forward speed for testing
            playerRigidbody2D.velocity = movementSettings.ForwardSpeed * movementDirection;
        }

        public void StopMovement()
        {
            playerRigidbody2D.velocity = Vector2.zero;
        }
    }
}