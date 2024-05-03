using Gameplay.Entities.Common.Aim;
using Gameplay.Entities.Common.Health;
using Gameplay.Entities.Common.Movement;
using Gameplay.Entities.Common.Weapons;
using System;
using UnityEngine;

namespace Gameplay.Entities.Player
{
    public class PlayerModel : MonoBehaviour, IMovementModel, IAimModel, IHealthModel
    {
        [Header("Player Model")]

        [Header("References")]
        [SerializeField] private Rigidbody2D playerRigidbody2D;
        [SerializeField] private Transform bodyTransform;

        [Header("Settings")]
        [SerializeField] private MovementSettings movementSettings;
        [SerializeField] private HealthSettings healthSettings;

        public event Action<int> OnHealthModified;
        public event Action OnHealthReachedZero;

        private IWeaponController currentWeapon;

        private int currentMaxHealth = 0;
        private int currentHealth = 0;
        private bool isAlive = true;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            currentMaxHealth = healthSettings.DefaulMaxHealth;
            ModifyHealth(currentMaxHealth);

            try
            {
                currentWeapon = bodyTransform.GetComponentInChildren<IWeaponController>();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }

        //Movement
        public void MoveTowards(Vector2 movementDirection)
        {
            //Only use forward speed for testing
            playerRigidbody2D.velocity = movementSettings.ForwardSpeed * movementDirection;
        }

        public void StopMovement()
        {
            playerRigidbody2D.velocity = Vector2.zero;
        }

        //Aiming
        public void AimTowards(Vector2 aimDirection)
        {
            bodyTransform.right = aimDirection;
        }

        //Health
        public void ReduceHealth(int amount)
        {
            ModifyHealth(Mathf.Abs(amount));
        }

        public void RestoreHealth(int amount)
        {
            ModifyHealth(-Mathf.Abs(amount));
        }

        private void ModifyHealth(int amount)
        {
            if (!isAlive)
            {
                return;
            }

            currentHealth = Mathf.Clamp(currentHealth + amount, 0, currentMaxHealth);
            OnHealthModified?.Invoke(currentHealth);

            if (currentHealth == 0)
            {
                isAlive = false;
                OnHealthReachedZero?.Invoke();
            }
        }

        public float GetNormalicedCurrentHealth()
        {
            return (float)currentHealth / currentMaxHealth;
        }
    }
}