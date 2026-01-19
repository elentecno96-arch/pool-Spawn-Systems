using Games.Interface;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Games.Monster.Strategy.Move
{
    public class NormalMove : IMoveStrategy
    {
        public void Move(Transform transform, float speed)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
