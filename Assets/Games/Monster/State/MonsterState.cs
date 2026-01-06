using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Monster.State
{
    public abstract class MonsterState
    {
        public MonsterStateMachine stateMachine;
        public Monster mon;

        public MonsterState(Monster monster)
        {
            this.mon = monster;
        }
        public virtual void StartState()
        {

        }
        public abstract void UpdateState();
        public virtual void ExitState()
        {

        }
    }
}
