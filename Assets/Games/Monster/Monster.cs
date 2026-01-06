using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.Interface;
using Games.Monster.Strategy;
using Unity.VisualScripting;
using Games.Monster.State;

namespace Games.Monster
{
    public abstract class Monster : MonoBehaviour, IHittable
    {
        public MoveStrategy moveStrategy;
        public AttackStrategy attackStrategy;
        public DieStrategy dieStrategy;

        public MonsterStateMachine stateMachine;

        int maxHp;
        int currentHp;
        public float moveSpeed;
        float damage;
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
            isDead = true;
            dieStrategy.Die(this.gameObject);
        }
    }
}
