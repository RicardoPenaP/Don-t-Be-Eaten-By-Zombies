using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapon.Projectiles
{
    [CreateAssetMenu(fileName = "NewProjectileSettings", 
                    menuName = "Gameplay/Entities/Common/Weapons/RangedWeapon/Projectiles/Projectile Settings")]
    public class ProjectileSettings : ScriptableObject
    {
        [Header("Projectile Settings")]        
        [SerializeField] private float range;
        [SerializeField] private float speed;

        public float Range => range;
        public float Speed => speed;
    }
}