using UnityEngine;

public static class ScreenUtils {
    public static float ScreenLeft { get; private set; }
    public static float ScreenRight { get; private set; }
    public static float ScreenTop { get; private set; }
    public static float ScreenBottom { get; private set; }

    static ScreenUtils() {
        UpdateScreenBounds();
    }

    public static void UpdateScreenBounds() {
        Camera mainCamera = Camera.main;
        Vector3 screenBottomLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector3 screenTopRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        ScreenLeft = screenBottomLeft.x;
        ScreenRight = screenTopRight.x;
        ScreenTop = screenTopRight.y;
        ScreenBottom = screenBottomLeft.y;
    }
}
