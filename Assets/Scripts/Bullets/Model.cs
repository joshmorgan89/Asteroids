using UnityEngine.VFX;

namespace Bullets {
    public class Model : ExpiringObjectModel {
        public int Damage = 1;
        public float Speed = 10.0f;
        public VisualEffect Explosion;
    }
}