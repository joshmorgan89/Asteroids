using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers {
    public class GameManager : MonoBehaviourSingleton<GameManager> {
        public Vector3 Gravity = Vector3.zero;
        public bool IsGamePaused = false;
        public bool IsGameOver = false;

        [Header("Game Settings")]
        public int Lives = 3;
        public int Score = 0;
        public int HighScore = 0;

        [Header("Player Settings")]
        public GameObject ShipPrefab;
        public Transform PlayerSpawnPoint;

        [Header("Asteroid Settings")]
        public GameObject AsteroidPrefab;
        public int InitialAsteroidCount = 5;
        public float SpawnRadius = 10.0f;
        public float MinDistanceFromPlayer = 2.0f;

        void Start() {
            Physics2D.gravity = Gravity;
            UpdateUI();
            StartGame();
        }

        private void Update() { }

        private void StartGame() {
            SpawnAsteroids(InitialAsteroidCount);
            // Other game start logic
        }

        private void SpawnAsteroids(int count) {
            for (int i = 0; i < count; i++) {
                Vector3 spawnPosition = GetSafeSpawnPosition();
                spawnPosition.x = Mathf.Clamp(spawnPosition.x, ScreenUtils.ScreenLeft + 1.0f, ScreenUtils.ScreenRight - 1.0f);
                spawnPosition.y = Mathf.Clamp(spawnPosition.y, ScreenUtils.ScreenBottom + 1.0f, ScreenUtils.ScreenTop - 1.0f);

                Quaternion spawnRotation = Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f));

                Instantiate(AsteroidPrefab, spawnPosition, spawnRotation);
            }
        }

        private Vector3 GetSafeSpawnPosition() {
            Vector3 spawnPosition;

            do {
                spawnPosition = GetRandomSpawnPosition();
            }
            while (Vector3.Distance(spawnPosition, PlayerSpawnPoint.position) < MinDistanceFromPlayer);

            return spawnPosition;
        }

        private Vector3 GetRandomSpawnPosition() {
            Vector2 randomDirection = Random.insideUnitCircle.normalized;
            float randomDistance = Random.Range(SpawnRadius * 0.5f, SpawnRadius);

            return randomDirection * randomDistance;
        }

        public void AddScore(int points) {
            Score += points;
            UpdateUI();
        }

        void UpdateUI() {
            UIManager.Instance.UpdateScore(Score);
            UIManager.Instance.UpdateLives(Lives);
        }

        void GameOver() {
            UIManager.Instance.ShowGameOverScreen();

            IsGameOver = true;

            // Handle high score
            if (Score > HighScore) {
                HighScore = Score;
            }
        }

        public void HandlePlayerDeath() {
            Lives--;

            if (Lives > 0) {
                RespawnPlayer();
            } else {
                GameOver();
            }

            UpdateUI();
        }

        public void RestartGame() {
            // Reload the current scene to restart the game
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            StartGame();
        }

        public void RespawnPlayer() {
            var newShip = Instantiate(ShipPrefab, PlayerSpawnPoint.position, PlayerSpawnPoint.rotation);
            InputManager.Instance.PlayerShip = newShip.GetComponent<Ships.Controller>();
        }

        public void TogglePause() {
            IsGamePaused = !IsGamePaused;
            UIManager.Instance.TogglePauseMenuScreen(IsGamePaused);
            Time.timeScale = IsGamePaused ? 0 : 1;
        }
    }
}