using Game.Interface;
using Games.Interface;
using Games.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Monster.Strategy.Die
{
    public class NormalDie : IMonsterDieStrategy
    {
        public virtual void Die(Monster monster)
        {
            PoolManager.instance.monPool.ReturnMonster(monster.gameObject);
        }
    }
}
