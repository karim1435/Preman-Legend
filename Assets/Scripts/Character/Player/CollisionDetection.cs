using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour {
    private Collider2D gameObj;

    [SerializeField]
    private Collider2D other;
    void Awake()
    {
        gameObj = GetComponent<Collider2D>();
        IgnoreCollision();
    }

    void IgnoreCollision()
    {
        Physics2D.IgnoreCollision(gameObj, other, true);
    }
}
