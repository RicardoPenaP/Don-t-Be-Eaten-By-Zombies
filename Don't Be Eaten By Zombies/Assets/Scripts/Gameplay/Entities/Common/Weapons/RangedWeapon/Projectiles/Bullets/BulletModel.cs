using Gameplay.Factories.Projectile;
using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapon.Projectiles.Bullets
{
    public class BulletModel : MonoBehaviour
    {
        [Header("Bullet Model")]
        [Header("References")]
        [SerializeField] private Rigidbody2D bulletRigidbody;

        private ProjectileData projectileData;

        public void SetProjectileData(ProjectileData projectileData)
        {
            this.projectileData = projectileData;
        }

        public void StartBulletMovement()
        {
            //bulletRigidbody.velocity = transform.right * projectileData.Speed;
        }
    }
}