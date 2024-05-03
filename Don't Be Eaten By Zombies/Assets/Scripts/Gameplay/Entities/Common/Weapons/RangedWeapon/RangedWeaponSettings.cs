using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapons
{
    [CreateAssetMenu(fileName = "NewRangedWeaponSettings", menuName = "Gameplay/Entities/Common/Weapons/Ranged Weapon Settings")]
    public class RangedWeaponSettings : ScriptableObject
    {
        [Header("Ranged Weapons Settings")]
        [SerializeField] private int damage;
        [SerializeField] private int clipSize;
        [SerializeField] private float reloadTime;
        [SerializeField] private float fireRate;

        public int Damage => damage;
        public int ClipSize => clipSize;
        public float ReloadTime => reloadTime;
        public float FireRate => fireRate;
    }
}