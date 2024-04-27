using UnityEngine;

namespace Gameplay.Entities.Common.Movement
{
    public interface IMovementModel 
    {
        public void MoveTowards(Vector2 movementDirection);
    }
}