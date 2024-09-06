using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    public float OoBOffset = 1.0f;

    private void Update() {
        WrapObject();
    }

    private void WrapObject() {
        Vector3 newPosition = transform.position;

        // Check if the object is off the screen horizontally
        if (transform.position.x > ScreenUtils.ScreenRight) {
            newPosition.x = ScreenUtils.ScreenLeft;
        } else if (transform.position.x < ScreenUtils.ScreenLeft) {
            newPosition.x = ScreenUtils.ScreenRight;
        }

        // Check if the object is off the screen vertically
        if (transform.position.y > ScreenUtils.ScreenTop) {
            newPosition.y = ScreenUtils.ScreenBottom;
        } else if (transform.position.y < ScreenUtils.ScreenBottom) {
            newPosition.y = ScreenUtils.ScreenTop;
        }

        // Apply the new position
        transform.position = newPosition;
    }
}
