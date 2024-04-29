using UnityEngine;

namespace Gameplay.Entities.Common.Aim
{
    public interface IAimModel
    {
        /// <summary>
        /// Aims towards a normalized direction.
        /// </summary>
        /// <param name="aimDirection">Normalized vector.</param>       
        public void AimTowards(Vector2 aimDirection);
    }
}