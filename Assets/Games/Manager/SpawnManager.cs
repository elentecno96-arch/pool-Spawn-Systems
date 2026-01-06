using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.Monster;

namespace Games.Manager
{
    public class SpawnManager : MonoBehaviour
    {
        public static SpawnManager instance;

        [SerializeField]
        private List<GameObject> spawnList;
        [SerializeField]
        private Transform spawnPoint;
        [SerializeField]
        private float spawnTime;
        [SerializeField]
        private float spawninterval;
        [SerializeField]
        private int maxSpawnCount;

        private void Awake()
        {
            maxSpawnCount = 3;
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        private void Update()
        {
            spawnTime += Time.deltaTime;
            if (spawnTime >= spawninterval)
            {
                Spawn();
                spawnTime = 0;
            }
        }
        void Spawn()
        {
            int currentMonsterCount = GameObject.FindGameObjectsWithTag("Monster").Length;

            if (currentMonsterCount < maxSpawnCount)
            {
                GameObject spawnObj = PoolManager.instance.monPool.GetMonster(spawnPoint.position, spawnPoint.rotation);
            }
        }
    }
}
