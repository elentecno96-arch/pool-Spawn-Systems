using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.Monster;

namespace Games.Interface
{
    public interface IMonsterAttackStrategy
    {
        void Attack(Games.Monster.Monster monster);
    }
}

