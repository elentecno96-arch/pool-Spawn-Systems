using Games.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Monster.Strategy.Die
{
    public class NormalDie : DieStrategy
    {
        public override void Die(GameObject obj)
        {
            PoolManager.instance.monPool.ReturnMonster(obj);
        }
    }
}
