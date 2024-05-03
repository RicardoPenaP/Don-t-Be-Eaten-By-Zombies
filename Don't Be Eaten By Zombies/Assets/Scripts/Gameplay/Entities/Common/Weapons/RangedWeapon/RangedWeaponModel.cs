using Gameplay.Entities.Common.Weapons.Common;
using Gameplay.Entities.Common.Weapons.Common.Attack;
using Gameplay.Entities.Common.Weapons.Common.Reload;
using System.Collections;
using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapons
{
    public class RangedWeaponModel : MonoBehaviour, IWeaponAttackModel, IWeaponReloadModel
    {
        [Header("Ranged Weapon Model")]
        [Header("References")]
        [SerializeField] private Transform shootingPosition;
        [SerializeField] private RangedWeaponSettings weaponSettings;

        private AmmoClip ammoClip;

        private float attackCooldown;
        private bool canAttack = true;
        private bool isReloading = false;


        private void Awake()
        {
            Init();
        }

        private void OnDestroy()
        {
            Deinit();
        }

        private void Init()
        {
            attackCooldown = 1 / weaponSettings.FireRate;
            ammoClip = new AmmoClip(weaponSettings.ClipSize);
            ammoClip.OutOfAmmo += AmmoClip_OutOfAmmo;
        }

        private void Deinit()
        {
            ammoClip.OutOfAmmo -= AmmoClip_OutOfAmmo;
        }

        private void AmmoClip_OutOfAmmo()
        {
            TryReload();
        }

        //Attack logic
        public bool TryAttack()
        {
            if (isReloading)
            {
                return false;
            }

            if (!canAttack)
            {
                return false;
            }

            //Bullet handling logic

            Debug.Log("Attack successfull");
            StartCoroutine(AttackCooldownRoutine());
            return true;
        }

        //Reload logic  
        public bool TryReload()
        {
            if (isReloading)
            {
                return false;
            }

            StartCoroutine(ReloadRoutine());
            return true;
        }

        private IEnumerator AttackCooldownRoutine()
        {
            canAttack = false;
            float timer = 0f;
            while (timer < attackCooldown)
            {
                timer += Time.deltaTime;
                yield return null;
            }
            canAttack = true;
        }

        private IEnumerator ReloadRoutine()
        {
            isReloading = true;
            float timer = 0f;
            while (timer < weaponSettings.ReloadTime)
            {
                timer += Time.deltaTime;
                yield return null;
            }
            //Testing feature, the final product must obtain the ammo from an ammo storage
            ammoClip.ReloadAmmo(ammoClip.MaxAmmo);
            isReloading = false;
        }
    }
}
