using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.Interface;
using Games.Monster.Strategy;
using Unity.VisualScripting;

namespace Games.Monster
{
    public abstract class Monster : MonoBehaviour, IHittable
    {
        protected MoveStrategy moveStrategy;
        protected AttackStrategy attackStrategy;
        protected DieStrategy dieStrategy;

        int maxHp;
        int currentHp;
        float moveSpeed;
        float damage;
        float atkSpeed;
        bool isDead;

        private void Start()
        {
            isDead = false;
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
            Destroy(gameObject);
        }
    }
}
