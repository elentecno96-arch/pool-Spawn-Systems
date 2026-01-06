using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

namespace Games.Pool
{
    public class EnemyPool : MonoBehaviour
    {
        public GameObject monster;
        public int poolSize;

        Queue<GameObject> monsterPool;

        private void Awake()
        {
            monsterPool = new Queue<GameObject>();
            poolSize = 50;
            for (int i = 0; i < poolSize; i++)
            {
                CreatMonster();
            }
        }
        GameObject CreatMonster()
        {
            GameObject mon = Instantiate(monster, transform);
            mon.SetActive(false);
            monsterPool.Enqueue(mon);
            return mon;
        }
        public GameObject GetMonster(Vector3 pos, Quaternion rot)
        {
            GameObject obj = monsterPool.Dequeue();
            obj.transform.position = pos;
            obj.transform.rotation = rot;
            obj.SetActive(true);
            return obj;
        }
        public void ReturnMonster(GameObject obj)
        {
            obj.SetActive(false);
            monsterPool.Enqueue(obj);
        }
    }
 
}
