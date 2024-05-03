using System;

namespace Gameplay.Entities.Common.Weapons.Common.Reload
{
    public class WeaponReloadController : IDisposable
    {
        private readonly IWeaponReloadView weaponReloadView;
        private readonly IWeaponReloadModel weaponReloadModel;

        public WeaponReloadController(IWeaponReloadView weaponReloadView, IWeaponReloadModel weaponReloadModel)
        {
            this.weaponReloadView = weaponReloadView;
            this.weaponReloadModel = weaponReloadModel;
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

        public void Reload()
        {

        }

    }
}