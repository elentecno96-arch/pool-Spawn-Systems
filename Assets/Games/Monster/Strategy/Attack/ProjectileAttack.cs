using Games.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.Pool;

namespace Games.Monster.Strategy.Attack
{
    public class ProjectileAttack : AttackStrategy
    {
        Monster monster;
        public override void Attack(Transform transform)
        {
            PoolManager.instance.projectilePool.GetProjectile(transform.position, transform.rotation);
        }
    }
}
