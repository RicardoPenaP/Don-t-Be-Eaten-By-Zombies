using UnityEngine;

namespace Gameplay.Entities.Common.Aim
{
    public interface IAimModel
    {
        /// <summary>
        /// Aims towards a normalized direction used to set the transform.Right vector.
        /// </summary>
        /// <param name="aimDirection">Normalized vector.</param>       
        public void AimTowards(Vector2 aimDirection);
    }
}