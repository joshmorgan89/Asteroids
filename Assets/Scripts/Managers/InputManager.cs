using UnityEngine;
using UnityEngine.InputSystem;

namespace Managers {
    public class InputManager : MonoBehaviourSingleton<InputManager> {
        public Ships.Controller PlayerShip = null;

        public void OnMovementInput(InputAction.CallbackContext context) {
            var value = context.ReadValue<Vector2>();

            PlayerShip.Model.MoveDirection = value.y;
            PlayerShip.Model.RotationValue = value.x;
        }

        public void OnShootInput(InputAction.CallbackContext context) {
            if (PlayerShip != null) {
                PlayerShip.GetComponent<Actions.Shoot>().IsShooting = context.performed;
            }
        }

        public void OnPauseInput(InputAction.CallbackContext context) {
            GameManager.Instance.TogglePause();
        }

        public void OnResetGameInput(InputAction.CallbackContext context) {
            GameManager.Instance.RestartGame();
        }
    }
}