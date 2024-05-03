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