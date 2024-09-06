using UnityEngine;
using UnityEngine.UI;

namespace Managers {
    public class UIManager : MonoBehaviourSingleton<UIManager> {

        [Header("UI Elements")]
        public Text LivesText;
        public Text ScoreText;
        public Text GameOverText;
        public GameObject PauseMenu;

        private void Start() {
            GameOverText.gameObject.SetActive(false);
            PauseMenu.SetActive(false);
        }

        public void UpdateLives(int lives) {
            if (LivesText != null) {
                LivesText.text = "Lives: " + lives;
            }
        }

        public void UpdateScore(int score) {
            if (ScoreText != null) {
                ScoreText.text = "Score: " + score;
            }
        }

        public void ShowGameOverScreen() {
            if (GameOverText != null) {
                GameOverText.gameObject.SetActive(true);
            }
        }

        public void TogglePauseMenuScreen(bool isPaused) {
            if (PauseMenu != null) {
                PauseMenu.SetActive(isPaused);
            }
        }
    }
}