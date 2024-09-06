using UnityEngine;

namespace Asteroids {
    public class Model : BaseModel {
        public int Size = 3; // The size of the asteroid, where a larger size indicates a bigger asteroid.
        public int Health = 3; // The health of the asteroid, which decreases with collisions.
        public float SpeedMin = 1.0f;
        public float SpeedMax = 3.0f;

        internal Vector2 InitialVelocity; // The initial velocity of the asteroid.

        public bool IsDestroyed => (Health <= 0);

        private void Start() {
            InitialVelocity = GenerateRandomVelocity();
        }

        // Method to apply damage to the asteroid
        public void ApplyDamage(int damage) {
            Health = System.Math.Min(Health - damage, 0);
        }

        // Method to generate a random velocity if none is provided
        private Vector2 GenerateRandomVelocity() {
            float speed = Random.Range(SpeedMin, SpeedMax);
            float angle = Random.Range(0f, 360f);
            return new Vector2(Mathf.Cos(angle) * speed, Mathf.Sin(angle) * speed);
        }
    }
}