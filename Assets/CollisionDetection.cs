using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour {
    private Collider2D gameObject ;

    [SerializeField]
    private Collider2D other;
    void Awake()
    {
        gameObject = GetComponent<Collider2D>();
        IgnoreCollision();
    }

    void IgnoreCollision()
    {
        Physics2D.IgnoreCollision(gameObject, other, true);
    }
}
