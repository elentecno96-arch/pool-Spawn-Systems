using Games.Pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Manager
{
    public class PoolManager : MonoBehaviour
    {
        public static PoolManager instance;
        public ProjectilePool projectilePool;
        public EnemyPool monPool;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
