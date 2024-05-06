namespace Gameplay.Entities.Common.Weapons.RangedWeapon.Projectiles
{
    public interface IProjectileController
    {
        public void SetProjectileData(ProjectileSettings projectileSettings);
        public void StarProjectileMovement();
       
    }
}
