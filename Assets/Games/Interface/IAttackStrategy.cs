using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.Monster;

namespace Games.Interface
{
    public interface IAttackStrategy
    {
        void Attack(Transform firePoint, float damage);
    }
}

