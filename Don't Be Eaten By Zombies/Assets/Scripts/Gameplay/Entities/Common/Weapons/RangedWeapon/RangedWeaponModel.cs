using Gameplay.Entities.Common.Weapons.Common.Attack;
using System.Collections;
using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapons
{
    public class RangedWeaponModel : MonoBehaviour, IWeaponAttackModel
    {
        [Header("Ranged Weapon Model")]
        [Header("References")]
        [SerializeField] private Transform shootingPosition;
        [SerializeField] private RangedWeaponSettings weaponSettings;

        private float attackCooldown;
        private bool canAttack = true;
        private bool isReloading = false;


        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            attackCooldown = 1 / weaponSettings.FireRate;
        }

        public bool TryAttack()
        {
            if (!canAttack)
            {
                return false;
            }

            //Bullet handling logic

            Debug.Log("Attack successfull");
            StartCoroutine(AttackCooldownRoutine());
            return true;
        }

        public bool TryReload()
        {
            return false;
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
    }
}
