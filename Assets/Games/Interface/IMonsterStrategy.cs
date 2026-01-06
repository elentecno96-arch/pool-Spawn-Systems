using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.Monster;

namespace Games.Interface
{
    public interface IMonsterStrategy
    {
        void Execute(Games.Monster.Monster monster);
    }
}

