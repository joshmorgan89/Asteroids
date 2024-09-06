using UnityEngine;

namespace Asteroids {
    public class View : BaseView
    {
        public ParticleSystem ExplosionEffect;
        public Sprite InitialSprite;

        private SpriteRenderer spriteRenderer;

        private void Awake() {
            spriteRenderer = GetComponent<SpriteRenderer>();
            if (InitialSprite != null) { SetSprite(InitialSprite); }
            
        }

        // Set the visual representation of the asteroid
        public void SetSprite(Sprite sprite) {
            spriteRenderer.sprite = sprite;
        }

        // Play an explosion effect when the asteroid is destroyed
        public void PlayExplosionEffect() {
            if (ExplosionEffect != null) {
                ExplosionEffect.transform.position = transform.position;
                ExplosionEffect.Play();
            }

            // Optionally, hide the sprite after the explosion
            spriteRenderer.enabled = false;
        }

        // Handle enabling and disabling the asteroid (for pooling or reusing objects)
        public void SetActive(bool isActive) {
            gameObject.SetActive(isActive);
        }

        // Optional: Update the asteroid's rotation visually (usually handled by Unity's Transform)
        public void SetRotation(float rotation) {
            transform.rotation = Quaternion.Euler(0, 0, rotation);
        }
    }
}