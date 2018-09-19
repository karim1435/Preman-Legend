using UnityEngine;
using System.Collections;

public class EnemyRange : MonoBehaviour {

    public delegate void OnEnemyRange(GameObject player);
    public event OnEnemyRange InRange;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (InRange != null)
                InRange(other.gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (InRange != null)
                InRange(null);
        }
    }
}
