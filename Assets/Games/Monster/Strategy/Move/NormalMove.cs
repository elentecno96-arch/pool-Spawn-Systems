using Games.Interface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Monster.Strategy.Move
{
    public class NormalMove : IMonsterStrategy
    {
        public virtual void Execute(Monster monster)
        {
            monster.transform.Translate(Vector3.forward * monster.moveSpeed * Time.deltaTime);
        }
    }
}
