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

        }

        private void Deinit()
        {

        }

        public void Dispose()
        {
            Deinit();
        }
    }
}
