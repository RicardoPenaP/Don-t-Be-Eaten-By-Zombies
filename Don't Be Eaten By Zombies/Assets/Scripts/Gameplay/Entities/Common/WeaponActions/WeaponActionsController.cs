using System;

namespace Gameplay.Entities.Common.WeaponActions
{
    public class WeaponActionsController : IDisposable
    {
        private readonly IWeaponActionsView weaponActionsView;
        private readonly IWeaponActionsModel weaponActionsModel;

        public WeaponActionsController(IWeaponActionsView weaponActionsView, IWeaponActionsModel weaponActionsModel)
        {
            this.weaponActionsView = weaponActionsView;
            this.weaponActionsModel = weaponActionsModel;
            Init();
        }

        private void Init()
        {
            weaponActionsView.OnAttackInputDetected += WeaponActionsView_OnAttackInputDetected;
            weaponActionsView.OnReloadInputDetected += WeaponActionsView_OnReloadInputDetected;
        }
        
        private void Deinit()
        {
            weaponActionsView.OnAttackInputDetected -= WeaponActionsView_OnAttackInputDetected;
            weaponActionsView.OnReloadInputDetected -= WeaponActionsView_OnReloadInputDetected;
        }

        public void Dispose()
        {
            Deinit();
        }

        private void WeaponActionsView_OnAttackInputDetected(bool obj)
        {
            weaponActionsModel.Attack();
        }

        private void WeaponActionsView_OnReloadInputDetected()
        {
            weaponActionsModel.Reload();
        }
    }
}