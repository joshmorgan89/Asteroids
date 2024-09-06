using Asteroids;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseController<M, V> : MonoBehaviour
    where M : BaseModel
    where V : BaseView
{
    protected M model;
    protected V view;
    protected Rigidbody2D rb;

    protected void Awake() {
        model = GetComponent<M>();
        view = GetComponent<V>();
        rb = GetComponent<Rigidbody2D>();
    }
}
