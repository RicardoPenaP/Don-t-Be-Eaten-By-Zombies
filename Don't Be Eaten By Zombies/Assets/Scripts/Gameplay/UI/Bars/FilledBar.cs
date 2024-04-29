using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UI.Bars
{
    public class FilledBar : MonoBehaviour
    {
        [Header("Filled Bar")]
        [Header("References")]
        [SerializeField] private Image fill;

        public void UpdateFill(float fillAmount)
        {
            fill.fillAmount = fillAmount;
        }
    }
}
