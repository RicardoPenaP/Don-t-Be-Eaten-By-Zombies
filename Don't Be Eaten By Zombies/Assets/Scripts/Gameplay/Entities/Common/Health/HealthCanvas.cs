using Gameplay.UI.Bars;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay.Entities.Common
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
