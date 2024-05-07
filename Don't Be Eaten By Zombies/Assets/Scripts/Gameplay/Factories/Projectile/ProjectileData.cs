using System;

namespace Gameplay.Factories.Projectile
{
    [Serializable]
    public class ProjectileData 
    {
        public readonly float speed;
        public readonly int damage;
        public readonly float range;

        public ProjectileData(float speed, int damage, float range)
        {
            this.speed = speed;
            this.damage = damage;
            this.range = range;
        }
    }
}
