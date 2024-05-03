using System;

namespace Gameplay.Entities.Common.WeaponsActions
{
    public class WeaponsActionsController : IDisposable
    {
        private readonly IWeaponsActionsView attackView;
        private readonly IWeaponsActionsModel attackModel;

        public WeaponsActionsController(IWeaponsActionsView attackView, IWeaponsActionsModel attackModel)
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