using System;

namespace Gameplay.Entities.Common.WeaponsActions
{
    public interface IAttackView
    {
        public event Action<bool> OnAttackInputDetected;
        public event Action OnReloadInputDetected;
    }
}