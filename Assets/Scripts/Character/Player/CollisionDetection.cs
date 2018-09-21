using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour {
    
    [SerializeField]
    private Collider2D other;

    private Collider2D gameObj;
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
