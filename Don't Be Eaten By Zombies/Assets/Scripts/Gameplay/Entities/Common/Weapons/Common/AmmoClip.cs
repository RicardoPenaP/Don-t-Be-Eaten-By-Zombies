using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.Common
{
    public class AmmoClip
    {
        private readonly int maxAmmo;
        private int currentAmmo;

        public int MaxAmmo => maxAmmo;

        public int CurrentAmmo => currentAmmo;

        public AmmoClip(int clipSize)
        {
            maxAmmo = clipSize;
            ReloadAmmo(maxAmmo);
        }

        public void ReloadAmmo(int amount)
        {
            currentAmmo = Mathf.Clamp(currentAmmo + amount, 0, maxAmmo);
        }

        public bool TryTakeAmmo()
        {
            if (currentAmmo <= 0)
            {
                return false;
            }
            currentAmmo--;
            return true;
        }
    }
}