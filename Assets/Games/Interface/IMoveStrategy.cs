using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.Monster;

namespace Games.Interface
{
    public interface IMoveStrategy
    {
        void Move(Transform transform, float speed);
    }
}

