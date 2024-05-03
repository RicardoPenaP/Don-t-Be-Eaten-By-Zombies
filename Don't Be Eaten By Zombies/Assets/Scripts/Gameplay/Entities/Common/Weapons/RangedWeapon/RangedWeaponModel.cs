using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapons
{
    public class RangedWeaponModel : MonoBehaviour
    {
        [Header("Ranged Weapon Model")]
        [Header("References")]
        [SerializeField] private Transform shootingPosition;
        [SerializeField] private RangedWeaponSettings weaponSettings;

        public void Attack()
        {

        }

        public void Reload()
        {

        }


    }
}
