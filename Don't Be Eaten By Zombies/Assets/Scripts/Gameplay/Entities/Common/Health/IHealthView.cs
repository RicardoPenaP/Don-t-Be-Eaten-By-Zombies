namespace Gameplay.Entities.Common.Health
{
    public interface IHealthView
    {
        /// <summary>
        /// Updates the health bar.
        /// </summary>
        /// <param name="normalizedCurrentHealth">Normalized value of the current health.</param>
        public void UpdateHealthBar(float normalizedCurrentHealth);
    }
}