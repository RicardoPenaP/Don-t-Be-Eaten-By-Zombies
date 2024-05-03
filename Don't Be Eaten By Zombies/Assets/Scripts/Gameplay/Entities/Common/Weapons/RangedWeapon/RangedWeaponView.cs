using Gameplay.Entities.Common.Weapons.Common.Attack;
using Gameplay.Entities.Common.Weapons.Common.Reload;
using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapons
{
    public class RangedWeaponView : MonoBehaviour, IWeaponAttackView, IWeaponReloadView
    {
        public void UpdateAttackFeedback()
        {
            //Trigger VFX and SFX for doing feedback for the player
            Debug.Log("Weapon VFX and SFX activated");
        }
    }
}
