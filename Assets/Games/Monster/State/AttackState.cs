using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Monster.State
{
    public class AttackState : MonsterState
    {
        private float attackRange = 5.0f;
        private float attackCooldown = 1.0f;
        private float lastAttackTime;
        public AttackState(Monster monster) : base(monster)
        {
        }

        public override void UpdateState()
        {
            Collider[] colliders = Physics.OverlapSphere(mon.transform.position, attackRange);
            bool playerInRange = false;
            Transform playerTransform = null;

            foreach (var hit in colliders)
            {
                if (hit.CompareTag("Player"))
                {
                    playerInRange = true;
                    playerTransform = hit.transform;
                    break;
                }
            }
            if (playerInRange)
            {
                mon.transform.LookAt(playerTransform);

                if (Time.time >= lastAttackTime + attackCooldown)
                {
                    mon.attackStrategy.Attack(mon);
                    lastAttackTime = Time.time;
                    Debug.Log("공격 전략 실행!");
                }
            }
            else
            {
                //mon.stateMachine.ChangeState("Move");
            }
        }
    }
}
