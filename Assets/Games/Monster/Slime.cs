using Games.Monster.Strategy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Monster
{

    public class Slime : Monster
    {
        public GameObject projectilePrefab;
        public Transform firePoint;
        protected override void Init()
        {
            moveStrategy = new Strategy.Move.NormalMove();
            attackStrategy = new Strategy.Attack.ProjectileAttack();
            dieStrategy = new Strategy.Die.NormalDie();
        }
    }
}
