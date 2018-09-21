using UnityEngine;
using System.Collections;
using System;
using Assets.Scripts.Weapon;
using Assets.Scripts.Characterrr;

[RequireComponent(typeof(Rigidbody2D))]
public class Knife : MonoBehaviour,IShoot, IWeapon
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float attackPower;

    private Rigidbody2D body2d;
    private Direction direction;

    public float AttackPower {get { return attackPower; }}
    void Start()
    {
        body2d = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        body2d.velocity = new Vector2((float)direction * speed,0);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    public void InitializeDirection(Direction direction)
    {
        this.direction = direction;
    }
}
