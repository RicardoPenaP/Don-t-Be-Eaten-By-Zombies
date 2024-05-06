using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapon.Projectiles.Bullets
{
    public class BulletController : MonoBehaviour, IProjectileController
    {
        [Header("Bullet Controller")]
        [Header("References")]
        [SerializeField] private BulletView bulletView;
        [SerializeField] private BulletModel bulletModel;

        public void SetProjectileData(ProjectileSettings projectileSettings)
        {
            throw new System.NotImplementedException();
        }

        public void StarProjectileMovement() => bulletModel.StartBulletMovement();        

    }
}