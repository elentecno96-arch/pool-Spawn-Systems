using Games.Interface;
using Games.Manager;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Games.Monster.Strategy.Die
{
    public class MonsterDie : IDieStrategy
    {
        public void Die(GameObject owner)
        {
            PoolManager.instance.monPool.ReturnMonster(owner);
        }
    }
}
