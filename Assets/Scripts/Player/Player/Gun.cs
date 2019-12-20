using UnityEngine;
namespace Spaceship_war
{
    public class Gun : MonoBehaviour
    {
        [Header("Bullets")]
        public GameObject bullet;

        [Header("Combat")]
        public float fireRate = 15f;
        public float bulletDamage = 0f;
        private float nextTimeToFire = 0f;


        void Start()
        {
            BulletProps bulletProps = bullet.GetComponent<BulletProps>();
            bulletProps.damage = bulletDamage;
        }


        // Update is called once per frame
        void Update()
        {
            if (VirtualInputManager.Instance.Fire1 && Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                Shoot();
            }
        }

        void Shoot()
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
