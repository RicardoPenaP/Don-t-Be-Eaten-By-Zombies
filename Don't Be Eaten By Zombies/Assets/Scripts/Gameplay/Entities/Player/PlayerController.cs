using Gameplay.Entities.Common.Aim;
using Gameplay.Entities.Common.Movement;
using Gameplay.Entities.Common.WeaponActions;
using UnityEngine;

namespace Gameplay.Entities.Player
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Player Controller")]
        [Header("References")]
        [SerializeField] private PlayerView playerView;
        [SerializeField] private PlayerModel playerModel;

        private MovementController movementController;
        private AimController aimController;
        private WeaponActionsController weaponActionsController;

        private void Awake()
        {
            Init();
        }

        private void OnDestroy()
        {
            Deinit();
        }

        private void Init()
        {
            movementController = new MovementController(playerView, playerModel);
            aimController = new AimController(playerView, playerModel);
            weaponActionsController = new WeaponActionsController(playerView, playerModel);
        }

        private void Deinit()
        {
            movementController.Dispose();
            aimController.Dispose();
            weaponActionsController.Dispose();
        }
    }
}
