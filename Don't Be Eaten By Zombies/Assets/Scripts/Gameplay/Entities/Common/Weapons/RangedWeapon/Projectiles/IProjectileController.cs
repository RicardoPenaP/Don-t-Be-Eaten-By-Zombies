using Gameplay.Entities.Common.Weapons.RangedWeapon.Projectiles;

namespace Gameplay.Entities.Common.Weapons.RangedWeapons.Projectiles
{
    public interface IProjectileController
    {
        public void SetProjectileData(ProjectileSettings projectileSettings);
        public void StarProjectileMovement();
       
    }
}
