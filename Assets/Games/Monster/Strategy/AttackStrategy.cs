using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Monster.Strategy
{
    public abstract class AttackStrategy
    {
        public abstract void Attack(Transform transform);
    }
}
