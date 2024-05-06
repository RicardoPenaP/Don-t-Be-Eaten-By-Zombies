using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapon.Projectiles.Bullets
{
    public class BulletModel : MonoBehaviour
    {
        [Header("Bullet Model")]
        [Header("References")]
        [SerializeField] private Rigidbody2D bulletRigidbody;

        private float speed;
        private int damage;

        public void StartBulletMovement()
        {
            bulletRigidbody.velocity = transform.right * speed;
        }
    }
}