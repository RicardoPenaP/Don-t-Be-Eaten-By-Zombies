namespace Gameplay.Entities.Common.Movement
{
    public class MovementController
    {
        private readonly IMovementView movementView;
        private readonly IMovementModel movementModel;

        public MovementController(IMovementView movementView, IMovementModel movementModel)
        {
            this.movementView = movementView;
            this.movementModel = movementModel;
        }

    }
}
