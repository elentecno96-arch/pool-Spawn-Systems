using Games.Interface;
using Games.Monster.State;
using Games.Monster.Strategy;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Games.Monster
{
    public abstract class Monster : MonoBehaviour, IHittable
    {
        public IMoveStrategy moveStrategy;
        public IAttackStrategy attackStrategy;
        public IDieStrategy dieStrategy;

        public MonsterStateMachine stateMachine;

        int maxHp;
        int currentHp;
        public float moveSpeed;
        public float damage;
        float atkSpeed;
        bool isDead;

        private void Start()
        {
            Init();
            isDead = false;
        }
        void Update()
        {
            stateMachine.UpdateState();
        }
        protected abstract void Init();
        public void Hit(float damage)
        {
            if (isDead) return;

            currentHp -= (int)damage;

            if (currentHp <= 0)
            {
                Die();
            }
        }
        void Die()
        {
            if (isDead) return;
            isDead = true;

            stateMachine.ChangeState("Die");
        }
    }
}
