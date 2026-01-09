using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Interface
{
    public interface IMonsterDieStrategy
    {
        void Die(Games.Monster.Monster monster);
    }
}
