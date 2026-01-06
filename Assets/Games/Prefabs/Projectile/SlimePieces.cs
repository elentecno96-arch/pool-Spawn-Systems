using Games.Interface;
using Games.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Prefabs.Projectile
{
    public class SlimePieces : MonoBehaviour, IClone<SlimePieces>
    {
        public float speed = 10f;
        public float lifeTime = 2f;
        private Rigidbody rb;

        public SlimePieces Clone()
        {
            GameObject cloneObj = Instantiate(this.gameObject);
            return cloneObj.GetComponent<SlimePieces>();
        }

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = transform.forward * speed;
            }
            StartCoroutine(ReturnAfterTime());
        }
        IEnumerator ReturnAfterTime()
        {
            yield return new WaitForSeconds(lifeTime);
            if (rb != null) rb.velocity = Vector3.zero;

            PoolManager.instance.projectilePool.ReturnProjectile(this.gameObject);
        }
    }
}
