using Gameplay.Factories.Projectile;
using System.Collections;
using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapon.Projectiles.Bullets
{
    public class BulletModel : MonoBehaviour
    {
        [Header("Bullet Model")]
        [Header("References")]
        [SerializeField] private Rigidbody2D bulletRigidbody;

        private ProjectileData projectileData;

        private Vector3 startPosition;

        public void SetProjectileData(ProjectileData projectileData)
        {
            this.projectileData = projectileData;
        }

        public void StartBulletMovement()
        {
            bulletRigidbody.velocity = transform.right * projectileData.speed;

            StartCoroutine(SelfDestructRoutine());
        }

        private IEnumerator SelfDestructRoutine()
        {
            startPosition = transform.position;
            while (Vector3.Distance(transform.position, startPosition) < projectileData.range)
            {
                yield return null;
            }

            SelfDestruct();
        }

        private void SelfDestruct()
        {
            Destroy(transform.parent.gameObject);
        }
    }
}