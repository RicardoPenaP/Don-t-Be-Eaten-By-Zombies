using Gameplay.Entities.Common.Weapons.RangedWeapon.Projectiles;
using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapon
{
    [CreateAssetMenu(fileName = "NewRangedWeaponSettings", menuName = "Gameplay/Entities/Common/Weapons/RangedWeapon/ Ranged Weapon Settings")]
    public class RangedWeaponSettings : ScriptableObject
    {
        [Header("Ranged Weapons Settings")]
        [SerializeField] private ProjectileSettings projectileSettings;
        [SerializeField] private int damage;
        [SerializeField] private int clipSize;
        [SerializeField] private float reloadTime;
        [SerializeField] private float fireRate;

        public ProjectileSettings ProjectileSettings => projectileSettings;
        public int Damage => damage;
        public int ClipSize => clipSize;
        public float ReloadTime => reloadTime;
        public float FireRate => fireRate;

    }
}