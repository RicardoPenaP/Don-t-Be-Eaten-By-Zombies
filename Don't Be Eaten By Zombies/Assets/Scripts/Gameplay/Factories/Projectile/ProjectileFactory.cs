using UnityEngine;

namespace Gameplay.Factories.Projectile
{
    public class ProjectileFactory : MonoBehaviour
    {
        private static ProjectileFactory instance;

        public static ProjectileFactory Instance => instance;

        [Header("Projectile Factory")]
        [Header("References")]
        [SerializeField] SpawnableProjectile[] projectilePrefabs;

        private void Awake()
        {
            if (instance is not null && !instance.Equals(this))
            {
                Destroy(this);
            }
            else
            {
                instance = this;                
            }
        }

        public void SpawnProjectile(Vector3 spawnPosition, SpawnableProjectileId id, ProjectileData projectileData)
        {
            if (TryGetProjectilePrefab(id, out SpawnableProjectile projectilePrefab))
            {
                
            }
            else
            {
                Debug.LogError($"This factory doesn\'t have any reference to that Id");
            }
        }

        private bool TryGetProjectilePrefab(SpawnableProjectileId id, out SpawnableProjectile projectilePrefab)
        {
            foreach (SpawnableProjectile projectile in projectilePrefabs)
            {
                if (!projectile.Id.Equals(id))
                {
                    continue;
                }
                else
                {
                    projectilePrefab = projectile;
                    return true;
                }
            }

            projectilePrefab = null;
            return false;
        }
    }
}
