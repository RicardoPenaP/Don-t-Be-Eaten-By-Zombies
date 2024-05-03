using System;

namespace Gameplay.Entities.Common.WeaponActions
{
    public interface IWeaponActionsView
    {
        public event Action<bool> OnAttackInputDetected;
        public event Action OnReloadInputDetected;
    }
}