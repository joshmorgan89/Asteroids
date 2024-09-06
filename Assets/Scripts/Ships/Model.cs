using UnityEngine.VFX;

namespace Ships {
    public class Model : BaseModel {
        public float Speed = 5.0f;
        public float RotationSpeed = 180.0f;
        public float Thrust = 0.1f;
        public VisualEffect Explosion;


        public float MoveDirection { get; set; }
        public float RotationValue { get; set; }
    }
}