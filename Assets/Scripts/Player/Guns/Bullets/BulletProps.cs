using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spaceship_war
{
    public class BulletProps : MonoBehaviour
    {
        [Header("Direction")]
        [Range(-1, 1)] public float moveX;
        [Range(-1, 1)] public float moveY;

        [Header("Movement")]
        public float speed;

        [Header("Combat")]
        public float damage;

        private Rigidbody2D Rigidbody2D;

        void Start()
        {
            Rigidbody2D = GetComponent<Rigidbody2D>();
        }
        private void Awake()
        {
            Rigidbody2D = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            float deltaTime = Time.deltaTime;

            float y = moveY * speed * deltaTime;
            float x = moveX * speed * deltaTime;

            Rigidbody2D.velocity = new Vector2(x, y);
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject, 2f);
        }
    }
}
