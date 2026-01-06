using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Monster.Strategy
{
    public abstract class MoveStrategy
    {
        public abstract void Move(Transform transform, float moveSpeed);
    }
}
