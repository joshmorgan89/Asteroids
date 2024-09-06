using UnityEngine;

namespace CollisionHandlers {
    public class Ship : CollisionHandler {
        private void OnCollisionEnter2D(Collision2D collision) {
            Ships.Controller ship = gameObject.GetComponent<Ships.Controller>();
            Asteroids.Controller asteroid = collision.gameObject.GetComponent<Asteroids.Controller>();

            if (asteroid != null) {
                ship.DestroyShip();
            }
        }
    }
}