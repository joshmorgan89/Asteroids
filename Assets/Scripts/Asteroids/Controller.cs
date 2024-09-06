using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.U2D;

namespace Asteroids {
    public class Controller : BaseController<Model, View>
    {
        public GameObject AsteroidPrefab;

        void Start() {
            // Set initial velocity based on model data
            rb.velocity = model.InitialVelocity;
        }

        void Update() {
            // Handle asteroid-specific updates
            if (model.IsDestroyed) {
                DestroyAsteroid();
            }
        }

        public void ApplyDamage(int damage) {
            model.Health -= damage;
            //view.UpdateHealth(model.Health);

            if (model.IsDestroyed) {
                Managers.GameManager.Instance.AddScore(100);
                DestroyAsteroid();
            } else {
                Managers.GameManager.Instance.AddScore(10);
            }
        }

        private void DestroyAsteroid() {
            SplitAsteroid();
            Destroy(gameObject);
        }

        private void SplitAsteroid() {
            // Logic for splitting asteroid into smaller parts
            // Instantiate smaller asteroids with adjusted models and views
            if (model.Size > 1) {
                // Spawn two smaller asteroids
                SpawnSmallerAsteroids();
            }
        }

        private void SpawnSmallerAsteroids() {
            for (int i = 0; i < 2; i++) {
                // Instantiate a new asteroid
                GameObject smallerAsteroid = Instantiate(AsteroidPrefab, transform.position, Quaternion.identity);
                Controller newAsteroid = smallerAsteroid.GetComponent<Controller>();

                // Set the new size
                newAsteroid.model.Size = model.Size - 1;
                newAsteroid.transform.localScale = transform.localScale * 0.5f;

                // Convert original heading to an angle in degrees
                float originalAngle = Mathf.Atan2(model.InitialVelocity.y, model.InitialVelocity.x) * Mathf.Rad2Deg;
                float angleRange = 20.0f;

                // Apply a random offset within the given angle range
                float randomOffset = Random.Range(-angleRange / 2.0f, angleRange / 2.0f);
                float newAngle = originalAngle + randomOffset;

                // Convert the new angle back to a direction vector
                newAsteroid.model.InitialVelocity = new Vector2(Mathf.Cos(newAngle * Mathf.Deg2Rad), Mathf.Sin(newAngle * Mathf.Deg2Rad));
                newAsteroid.model.Health = newAsteroid.model.Size;
            }
        }
    }
}