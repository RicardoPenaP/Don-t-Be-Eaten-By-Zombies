using Gameplay.UI.Bars;
using UnityEngine;

namespace Gameplay.Entities.Common.Health
{
    public class HealthCanvas : MonoBehaviour
    {
        [Header("Health Canvas")]
        [Header("References")]
        [SerializeField] private FilledBar healthBar;

        public void UpdateHealthBar(float healthAmount)
        {
            healthBar.UpdateFill(healthAmount);
        }
    }
}
