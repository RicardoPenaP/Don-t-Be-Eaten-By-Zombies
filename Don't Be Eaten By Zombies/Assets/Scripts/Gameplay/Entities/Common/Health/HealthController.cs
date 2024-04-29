using System;

namespace Gameplay.Entities.Common.Health
{
    public class HealthController : IDisposable
    {
        private readonly IHealthView healthView;
        private readonly IHealthModel healthModel;

        public HealthController(IHealthView healthView, IHealthModel healthModel)
        {
            this.healthView = healthView;
            this.healthModel = healthModel;
            Init();
        }

        private void Init()
        {
            healthModel.OnHealthModified += HealthModel_OnHealthModified;
            healthModel.OnHealthReachedZero += HealthModel_OnHealthReachedZero;
        }

        private void Deinit()
        {
            healthModel.OnHealthModified -= HealthModel_OnHealthModified;
            healthModel.OnHealthReachedZero -= HealthModel_OnHealthReachedZero;
        }

        public void Dispose()
        {
            Deinit();
        }

        private void HealthModel_OnHealthModified(int currentHealth)
        {
            
        }

        private void HealthModel_OnHealthReachedZero()
        {
            
        }
    }
}
