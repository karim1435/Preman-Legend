using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Knife : MonoBehaviour {

    [SerializeField]
    private float speed;

    private Rigidbody2D body2d;

    private Vector2 direction;

    void Start()
    {
        body2d = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        body2d.velocity = direction * speed;
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
