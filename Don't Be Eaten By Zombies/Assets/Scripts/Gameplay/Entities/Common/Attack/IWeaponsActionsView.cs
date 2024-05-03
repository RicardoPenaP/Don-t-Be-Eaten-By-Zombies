using System;

namespace Gameplay.Entities.Common.WeaponsActions
{
    public interface IWeaponsActionsView
    {
        public event Action<bool> OnAttackInputDetected;
        public event Action OnReloadInputDetected;
    }
}