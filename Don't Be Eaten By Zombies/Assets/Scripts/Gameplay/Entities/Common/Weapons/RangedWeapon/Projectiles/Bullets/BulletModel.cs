using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapon.Projectiles.Bullets
{
    public class BulletModel : MonoBehaviour
    {
        [Header("Bullet Model")]
        [Header("References")]
        [SerializeField] private Rigidbody2D bulletRigidbody;

        private ProjectileSettings projectileSettings;

        public void SetProjectileData(ProjectileSettings projectileSettings)
        {
            this.projectileSettings = projectileSettings;
        }

        public void StartBulletMovement()
        {
            bulletRigidbody.velocity = transform.right * projectileSettings.Speed;
        }
    }
}