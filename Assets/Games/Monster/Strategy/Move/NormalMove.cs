using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Monster.Strategy.Move
{
    public class NormalMove : MoveStrategy
    {
        public override void Move(Transform transform, float moveSpeed)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
