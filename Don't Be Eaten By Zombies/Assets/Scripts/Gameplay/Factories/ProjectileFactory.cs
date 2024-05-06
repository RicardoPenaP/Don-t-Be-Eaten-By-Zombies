using UnityEngine;

namespace Gameplay.Factories
{
    public class ProjectileFactory : MonoBehaviour
    {
        private static ProjectileFactory instance;

        public static ProjectileFactory Instance => instance;

        [Header("Projectile Factory")]
        [Header("References")]
        [SerializeField] GameObject projectiles;

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

        public GameObject SpawnProjectile(Vector3 spawnPosition)
        {
            return null;
        }
    }
}
