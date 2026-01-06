using Games.Interface;
using Games.Prefabs.Projectile;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Pool
{
    public class ProjectilePool : MonoBehaviour
    {
        public SlimePieces sPprojectile;
        public int poolsize;

        Queue<GameObject> projectilePool;

        private void Awake()
        {
            poolsize = 10;
            projectilePool = new Queue<GameObject>();
            for (int i = 0; i < poolsize; i++)
            {
                CrateProjectile();
            }
        }
        GameObject CrateProjectile()
        {
            SlimePieces sp = sPprojectile.Clone();
            GameObject obj = sp.gameObject;
            obj.transform.SetParent(this.transform);
            obj.SetActive(false);
            projectilePool.Enqueue(obj);
            return obj;
        }
        public GameObject GetProjectile(Vector3 pos, Quaternion rot)
        {
            GameObject obj = projectilePool.Dequeue();
            obj.transform.position = pos;
            obj.transform.rotation = rot;
            obj.SetActive(true);
            return obj;
        }
        public void ReturnProjectile(GameObject obj)
        {
            obj.SetActive(false);
            projectilePool.Enqueue(obj);
        }
    }
}
