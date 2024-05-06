using Gameplay.Factories.Projectile;
using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapon.Projectiles.Bullets
{
    public class BulletController : MonoBehaviour, IProjectileController
    {
        [Header("Bullet Controller")]
        [Header("References")]
        [SerializeField] private BulletView bulletView;
        [SerializeField] private BulletModel bulletModel;

        public void SetProjectileData(ProjectileData projectileData)
        {
            bulletModel.SetProjectileData(projectileData);
            bulletModel.StartBulletMovement();
        }
     

    }
}