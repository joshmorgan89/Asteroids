using UnityEngine;

public class ExpiringObjectModel : BaseModel
{
    public delegate void OnExpiration();
    public float Lifespan = 3.0f;

    private float _timeAlive = 0;

    public bool IsExpired => _timeAlive > Lifespan;

    private void Start() {
        Destroy(gameObject, Lifespan);
    }

    private void Update() {
        _timeAlive += Time.deltaTime;
    }
}
