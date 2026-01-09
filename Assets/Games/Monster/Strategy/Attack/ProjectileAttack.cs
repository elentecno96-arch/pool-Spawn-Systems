using Games.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.Pool;
using Games.Interface;

namespace Games.Monster.Strategy.Attack
{
    public class ProjectileAttack : IMonsterAttackStrategy
    {
        public virtual void Attack(Monster monster)
        {
            PoolManager.instance.projectilePool.GetProjectile(monster.transform.position, monster.transform.rotation);
        }
    }
}
