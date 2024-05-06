using UnityEngine;

namespace Gameplay.Factories.Projectile
{
    public class SpawnableProjectile : MonoBehaviour
    {
        [Header("Spawnable Projectile")]
        [SerializeField] private SpawnableProjectileId id;

        public SpawnableProjectileId Id => id;
    }
}