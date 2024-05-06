using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapon.Projectiles
{
    [CreateAssetMenu(fileName = "NewProjectileSettings", 
                    menuName = "Gameplay/Entities/Common/Weapons/RangedWeapon/Projectiles/Bullet Settings")]
    public class ProjectileSettings : ScriptableObject
    {
        [Header("Projectile Settings")]
        [SerializeField] private int damage;
        [SerializeField] private float range;
        [SerializeField] private float speed;

        public int Damage => damage;

        public float Range => range;
        public float Speed => speed;
    }
}