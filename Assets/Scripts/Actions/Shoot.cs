using UnityEngine;

namespace Actions {
    public class Shoot : Action
    {
        public GameObject BulletPrefab;       // The bullet prefab to instantiate
        public Transform BulletSpawnPoint;    // The point from where bullets will be fired
        public float BulletSpeed = 10f;       // Speed at which the bullet moves
        public float FireRate = 0.5f;         // Time between shots (in seconds)
        private float _nextFireTime = 0f;      // Time when the player can fire next

        public bool IsShooting {  get; set; }

        void Update() {
            // Check if the fire button is pressed and if enough time has passed since the last shot
            if (IsShooting && Time.time > _nextFireTime) {
                PerformAction();
            }
        }

        private void ResetTimer () {
            _nextFireTime = Time.time + FireRate;
        }

        public override void PerformAction() {
            // Instantiate a bullet at the bullet spawn point
            GameObject bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);

            // Get the Rigidbody2D component of the bullet and set its velocity
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = BulletSpawnPoint.up * BulletSpeed;

            ResetTimer();
        }
    }
}
