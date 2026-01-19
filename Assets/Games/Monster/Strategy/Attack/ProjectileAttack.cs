using Games.Interface;
using Games.Manager;
using Games.Pool;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Games.Monster.Strategy.Attack
{
    public class ProjectileAttack : IAttackStrategy
    {
        public void Attack(Transform firePoint, float damage)
        {
            PoolManager.instance.projectilePool.GetProjectile(firePoint.position, firePoint.rotation);
        }
    }
}
