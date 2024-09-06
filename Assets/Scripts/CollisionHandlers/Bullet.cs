using UnityEngine;

namespace CollisionHandlers {
    public class Bullet : CollisionHandler {
        private void OnCollisionEnter2D(Collision2D collision) {
            Bullets.Controller bullet = gameObject.GetComponent<Bullets.Controller>();
            Asteroids.Controller asteroid = collision.gameObject.GetComponent<Asteroids.Controller>();

            if (asteroid != null)
            {
                asteroid.ApplyDamage(bullet.Model.Damage);
                bullet.DestroyBullet();
            }
        }
    }
}
