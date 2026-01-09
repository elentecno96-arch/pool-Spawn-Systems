using Games.Monster.Strategy;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Games.Monster.State
{
    public class MoveState : MonsterState
    {
        float detectRange = 4;
        public MoveState(Monster monster) : base(monster)
        {

        }

        public override void UpdateState()
        {
            mon.moveStrategy.Move(mon);

            Collider[] colliders = Physics.OverlapSphere(mon.transform.position, detectRange);
            foreach (var hit in colliders)
            {
                if (hit.CompareTag("Player"))
                {
                    //mon.stateMachine.ChangeState("Attack");
                    break;
                }
            }
        }
    }
}
