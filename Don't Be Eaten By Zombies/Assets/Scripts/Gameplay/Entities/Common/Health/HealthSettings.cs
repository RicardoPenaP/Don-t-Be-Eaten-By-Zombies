using UnityEngine;

namespace Gameplay.Entities.Common.Health
{
    [CreateAssetMenu(fileName = "NewHealthSettings", menuName = "Gameplay/Entities/Common/Health/Health Settings")]
    public class HealthSettings : ScriptableObject
    {
        [Header("Health Settings")]
        [SerializeField] private int defaulMaxHealth = 100;

        public int DefaulMaxHealth => defaulMaxHealth;
    }
}