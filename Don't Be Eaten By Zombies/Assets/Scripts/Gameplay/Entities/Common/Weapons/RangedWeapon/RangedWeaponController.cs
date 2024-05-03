using Gameplay.Entities.Common.Weapons.Common.Attack;
using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapons
{
    public class RangedWeaponController : MonoBehaviour
    {
        [Header("Ranged Weapon Controller")]
        [Header("References")]
        [SerializeField] private RangedWeaponView rangedWeaponView;
        [SerializeField] private RangedWeaponModel rangedWeaponModel;

        private WeaponAttackController weaponAttackController;

        private void Awake()
        {
            weaponAttackController = new WeaponAttackController(rangedWeaponView, rangedWeaponModel);
        }

        private void OnDestroy()
        {
            weaponAttackController.Dispose();
        }

        public void Attack() => weaponAttackController.Attack();

        public void Reload()
        {

        }


    }
}
