using System;
using UnityEngine;

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
            aimView.OnAimInputDetected += AimView_OnAimInputDetected;
        }

        private void Deinit()
        {
            aimView.OnAimInputDetected -= AimView_OnAimInputDetected;
        }

        public void Dispose()
        {
            Deinit();
        }

        private void AimView_OnAimInputDetected(Vector2 rawAimInput)
        {
            if (rawAimInput.Equals(Vector2.zero))
            {
                return;
            }
            aimModel.AimTowards(rawAimInput.normalized);
        }

    }
}
