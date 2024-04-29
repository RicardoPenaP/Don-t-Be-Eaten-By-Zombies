using System;

namespace Gameplay.Entities.Common.Aim
{
    public class AimController : IDisposable
    {
        private readonly IAimView aimView;
        private readonly IAimModel aimModel;

        public AimController(IAimView aimView, IAimModel aimModel)
        {
            this.aimView = aimView;
            this.aimModel = aimModel;
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
