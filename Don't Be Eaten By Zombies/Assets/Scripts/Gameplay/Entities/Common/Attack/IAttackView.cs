using System;

namespace Gameplay.Entities.Common.Attack
{
    public interface IAttackView
    {
        public event Action<bool> OnAttackInputDetected;
        public event Action OnReloadInputDetected;
    }
}