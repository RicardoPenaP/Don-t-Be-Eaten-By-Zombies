using System;

namespace Gameplay.Entities.Common.Weapons.Common.Attack
{
    public class WeaponAttackController : IDisposable
    {
        private readonly IWeaponAttackView weaponAttackView;
        private readonly IWeaponAttackModel weaponAttackModel;

        public WeaponAttackController(IWeaponAttackView weaponAttackView, IWeaponAttackModel weaponAttackModel)
        {
            this.weaponAttackView = weaponAttackView;
            this.weaponAttackModel = weaponAttackModel;
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

        public void Attack()
        {
            if (weaponAttackModel.TryAttack())
            {
                weaponAttackView.UpdateAttackFeedback();
            }
        }
    }
}