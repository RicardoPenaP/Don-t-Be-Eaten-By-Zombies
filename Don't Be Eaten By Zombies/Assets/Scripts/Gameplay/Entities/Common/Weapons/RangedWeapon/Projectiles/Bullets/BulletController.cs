﻿using Gameplay.Entities.Common.Weapons.RangedWeapons.Projectiles;
using UnityEngine;

namespace Gameplay.Entities.Common.Weapons.RangedWeapon.Projectiles.Bullets
{
    public class BulletController : MonoBehaviour, IProjectileController
    {
        [Header("Bullet Controller")]
        [Header("References")]
        [SerializeField] BulletView bulletView;
        [SerializeField] BulletModel bulletModel;



        public void SetProjectileData()
        {
            throw new System.NotImplementedException();
        }

        public void StarProjectileMovement()
        {
            throw new System.NotImplementedException();
        }

    }
}