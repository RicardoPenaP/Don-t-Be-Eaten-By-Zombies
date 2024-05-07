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

        public void SpawnProjectile(Vector3 spawnPosition, Vector3 rotation, SpawnableProjectileId id, ProjectileData projectileData)
        {
            if (TryGetProjectilePrefab(id, out SpawnableProjectile projectilePrefab))
            {
                IProjectileController projectileController = Instantiate(projectilePrefab, spawnPosition, Quaternion.Euler(rotation), transform)
                                                            .GetComponentInChildren<IProjectileController>();
                projectileController.SetProjectileData(projectileData);
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
