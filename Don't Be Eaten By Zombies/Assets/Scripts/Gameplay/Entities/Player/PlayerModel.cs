using Gameplay.Entities.Common.Movement;
using UnityEngine;

namespace Gameplay.Entities.Player
{
    public class PlayerModel : MonoBehaviour, IMovementModel
    {
        [Header("Player Model")]
        [Header("References")]
        [SerializeField] private Rigidbody2D playerRigidbody2D;

        public void MoveTowards(Vector2 movementDirection)
        {
            throw new System.NotImplementedException();
        }

        public void StopMovement()
        {
            playerRigidbody2D.velocity = Vector2.zero;
        }
    }
}