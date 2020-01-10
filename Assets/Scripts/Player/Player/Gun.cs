using UnityEngine;
namespace Spaceship_war
{
    public class Gun : MonoBehaviour
    {
        [Header("Bullets")]
        public GameObject bullet;

        [Header("Combat")]
        public float fireRate = 15f;
        public float fireRateHeavy = 10f;
        public float bulletDamage = 0f;
        private float nextTimeToFire = 0f;
        private float nextTimeToFireHeavy = 0f;



        void Start()
        {
            BulletProps bulletProps = bullet.GetComponent<BulletProps>();
            bulletProps.damage = bulletDamage;
        }


        void Update()
        {
            if (VirtualInputManager.Instance.HeavyFire && Time.time >= nextTimeToFire)
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
