using Games.Interface;
using Games.Monster.State;
using Games.Monster.Strategy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Monster
{

    public class Slime : Monster
    {
        protected override void Init()
        {
            stateMachine = new MonsterStateMachine(this);
            stateMachine.AddState("Idle", new IdleState(this));
            stateMachine.AddState("Move", new MoveState(this));
            stateMachine.AddState("Attack", new AttackState(this));
            stateMachine.AddState("Die", new DieState(this));

            moveStrategy = new Strategy.Move.NormalMove();
            attackStrategy = new Strategy.Attack.ProjectileAttack();
            dieStrategy = new Strategy.Die.MonsterDie();

            stateMachine.ChangeState("Idle");
        }
    }
}
