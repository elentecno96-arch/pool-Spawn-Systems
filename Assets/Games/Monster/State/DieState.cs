using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.Monster.Strategy.Die;

namespace Games.Monster.State
{
    public class DieState : MonsterState
    {
        public DieState(Monster monster) : base(monster)
        {
        }
        public override void StartState()
        {
            mon.dieStrategy.Die(mon.gameObject);
        }
        public override void UpdateState() { }
    }
}
