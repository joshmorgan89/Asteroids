using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CollisionHandlers {
    public class CollisionHandler : MonoBehaviour {
        void OnCollisionEnter2D(Collision2D collision) {
            Debug.Log(collision.gameObject.tag + " collided with " + gameObject.tag);
        }
    }
}