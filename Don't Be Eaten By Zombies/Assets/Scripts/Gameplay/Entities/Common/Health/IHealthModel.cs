using System;

namespace Gameplay.Entities.Common.Health
{
    public interface IHealthModel 
    {
        public event Action<int> OnHealthModified;
        public event Action OnHealthReachedZero;

        public void ReduceHealth(int amount);
        public void RestoreHealth(int amount);
    }
}