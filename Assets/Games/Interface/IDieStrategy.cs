using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Interface
{
    public interface IDieStrategy
    {
        void Die(GameObject owner);
    }
}
