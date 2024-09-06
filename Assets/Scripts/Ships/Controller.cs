using UnityEngine;

namespace Ships {
    public class Controller : BaseController<Model, View> {
        public Model Model => model;

        private void Update() {
            ApplyThrust(model.MoveDirection);
            ApplyRotation(model.RotationValue);
        }

        private void ApplyThrust(float direction) {
            direction = Mathf.Clamp(direction, -1, 1);
            rb.AddForce(transform.up * model.Thrust * direction);
        }

        private void ApplyRotation(float value) {
            rb.rotation -= model.RotationSpeed * value;
        }

        public void DestroyShip() {
            // Play animations and whatever else we need to do when the ship dies
            gameObject.SetActive(false);
            Managers.GameManager.Instance.HandlePlayerDeath();
            Destroy(gameObject);
        }
    }
}