using UnityEngine;
using System.Collections;

public class IgnoreColiision : MonoBehaviour {

    [SerializeField]
    private Collider2D other;

    void Awake()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), other, true);
    }
}
