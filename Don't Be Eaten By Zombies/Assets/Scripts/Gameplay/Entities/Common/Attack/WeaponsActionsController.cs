using System;

namespace Gameplay.Entities.Common.WeaponsActions
{
    public class WeaponsActionsController : IDisposable
    {
        private readonly IWeaponsActionsView attackView;
        private readonly IAttackModel attackModel;

        public WeaponsActionsController(IWeaponsActionsView attackView, IAttackModel attackModel)
        {
            this.attackView = attackView;
            this.attackModel = attackModel;
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