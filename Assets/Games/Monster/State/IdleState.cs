using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Monster.State
{
    public class IdleState : MonsterState
    {
        float detectRange = 4;
        public IdleState(Monster monster) : base(monster)
        {
        }

        public override void UpdateState()
        {
            Collider[] colliders = Physics.OverlapSphere(mon.transform.position, detectRange);
            foreach (var hit in colliders)
            {
                if (hit.CompareTag("Player"))
                {
                    Debug.Log("플레이어를 찾음");
                    mon.stateMachine.ChangeState("Move");
                    break;
                }
            }
        }
    }
}
