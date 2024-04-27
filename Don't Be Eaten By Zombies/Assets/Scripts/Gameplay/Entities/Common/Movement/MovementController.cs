using System;
using UnityEngine;

namespace Gameplay.Entities.Common.Movement
{
    public class MovementController : IDisposable
    {
        private readonly IMovementView movementView;
        private readonly IMovementModel movementModel;

        public MovementController(IMovementView movementView, IMovementModel movementModel)
        {
            this.movementView = movementView;
            this.movementModel = movementModel;
            Init();
        }

        private void Init()
        {
            movementView.OnMoveInputDetected += MovementView_OnMoveInputDetected;
        }

        private void Deinit()
        {
            movementView.OnMoveInputDetected -= MovementView_OnMoveInputDetected;
        }

        public void Dispose()
        {
            Deinit();
        }

        private void MovementView_OnMoveInputDetected(Vector2 rawMovementInput)
        {
            if (rawMovementInput.Equals(Vector2.zero))
            {
                movementModel.StopMovement();
            }
            else
            {
                movementModel.MoveTowards(rawMovementInput.normalized);
            }
        }
    }
}
