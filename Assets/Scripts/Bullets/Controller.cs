using UnityEngine;

namespace Bullets {
    public class Controller : BaseController<Model, View> {
        public Model Model => model;

        void Start() {
            rb.velocity = transform.up * model.Speed;
        }

        public void DestroyBullet() {
            var explosionEffect = Instantiate(model.Explosion, gameObject.transform.position, Quaternion.identity);
            explosionEffect.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            explosionEffect.Play();
            Destroy(gameObject);
        }
    }
}
