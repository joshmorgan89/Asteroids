using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids {
    public class Movement : MonoBehaviour
    {
        //private Rigidbody2D rb;
        //private Model model;

        //void Start() {
        //    rb = GetComponent<Rigidbody2D>();

        //    // Initialize the asteroid's movement with a random direction
        //    direction = Random.insideUnitCircle.normalized;
        //    rb.velocity = direction * speed;
        //}

        //void Update() {
        //    // Handle wrapping around the screen if the asteroid goes off the edge
        //    HandleScreenWrap();
        //}

        //private void HandleScreenWrap() {
        //    Vector2 newPosition = transform.position;

        //    if (newPosition.x > ScreenUtils.ScreenRight) {
        //        newPosition.x = ScreenUtils.ScreenLeft;
        //    } else if (newPosition.x < ScreenUtils.ScreenLeft) {
        //        newPosition.x = ScreenUtils.ScreenRight;
        //    }

        //    if (newPosition.y > ScreenUtils.ScreenTop) {
        //        newPosition.y = ScreenUtils.ScreenBottom;
        //    } else if (newPosition.y < ScreenUtils.ScreenBottom) {
        //        newPosition.y = ScreenUtils.ScreenTop;
        //    }

        //    transform.position = newPosition;
        //}

        //private void SpawnSmallerAsteroids() {
        //    // Adjust the size and speed for the smaller asteroids
        //    int newSize = size - 1;
        //    float newSpeed = speed * 1.5f;

        //    for (int i = 0; i < 2; i++) {
        //        // Instantiate a new asteroid
        //        GameObject smallerAsteroid = Instantiate(gameObject, transform.position, Quaternion.identity);
        //        Movement asteroidMovement = smallerAsteroid.GetComponent<Movement>();

        //        // Set the new size and speed
        //        asteroidMovement.size = newSize;
        //        asteroidMovement.speed = newSpeed;

        //        // Randomize the direction for the smaller asteroids
        //        asteroidMovement.direction = Random.insideUnitCircle.normalized;
        //        asteroidMovement.rb.velocity = asteroidMovement.direction * newSpeed;
        //    }
        //}
    }
}
